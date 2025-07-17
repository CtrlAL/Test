using Api.Models.Response;
using BL.Services.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OuterSourceIntegrationController : ControllerBase
    {
        private readonly IDiagnosticBL _diagnosticBL;

        public OuterSourceIntegrationController(IDiagnosticBL diagnosticBL)
        {
            _diagnosticBL = diagnosticBL;
        }

        [HttpPost("post-current-consumption/{userId}")]
        public async Task<ActionResult<ApiResponse<bool>>> GetCurrent(IFormFile jsonFile, [FromRoute] int userId)
        {
            if (jsonFile.ContentType != "application/json") 
            {
                return BadRequest("Wrong file type");
            }

            if (!jsonFile.FileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest("Invalid file format. Only JSON files are allowed.");
            }

            var result = await _diagnosticBL.TryGetByUserId(userId);

            try
            {
                using (var reader = new StreamReader(jsonFile.OpenReadStream()))
                {
                    string json = await reader.ReadToEndAsync();
                    var nutrientConsumptions = JsonConvert.DeserializeObject<List<NutrientConsumption>>(json);

                    if (result.exist)
                    {
                        result.diagnostic.NutrientConsumptions = nutrientConsumptions;
                        await _diagnosticBL.UpdateAsync(result.diagnostic);
                    }
                    else
                    {
                        result.diagnostic = new Diagnostic
                        {
                            Id = 0,
                            NutrientConsumptions = nutrientConsumptions
                        };

                        await _diagnosticBL.AddAsync(result.diagnostic);
                    }
                }
            }
            catch(Exception ex)
            {
                return Ok(ApiResponse<bool>.Fail($"Server error: {ex.Message}"));
            }

            return Ok(ApiResponse<bool>.Success(true));
        }
    }
}
