using Api.Models;
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
        private readonly INutrientConsumptionBL _nutrientConsumptionBL;

        public OuterSourceIntegrationController(IDiagnosticBL diagnosticBL, INutrientConsumptionBL nutrientConsumptionBL)
        {
            _diagnosticBL = diagnosticBL;
            _nutrientConsumptionBL = nutrientConsumptionBL;
        }

        [HttpPost("post-current-consumption/{userId}")]
        public async Task<ActionResult<ApiResponse<bool>>> FromJson(IFormFile jsonFile, [FromRoute] int userId)
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
                        nutrientConsumptions.ForEach(x => x.DiagnosticId = result.diagnostic.Id);
                        await _nutrientConsumptionBL.UpdateListAsync(nutrientConsumptions);
                    }
                    else
                    {
                        var id = await _diagnosticBL.AddAsync(new Diagnostic
                        {
                            UserId = userId,
                        });

                        nutrientConsumptions.ForEach(x => x.DiagnosticId = id);

                        await _nutrientConsumptionBL.AddListAsync(nutrientConsumptions);
                    }
                }
            }
            catch(Exception ex)
            {
                return Ok(ApiResponse<bool>.Fail($"Server error: {ex.Message}"));
            }

            return Ok(ApiResponse<bool>.Success(true));
        }

        [HttpGet("post-current-consumption/{userId}")]
        public async Task<ActionResult<ApiResponse<DiagnosticModel>>> GetByUserId([FromRoute] int userId)
        {
            var (entity, exist) = await _diagnosticBL.TryGetByUserId(userId);

            if (exist)
            {
                var response = DiagnosticModel.FromEntity(entity);
                return Ok(ApiResponse<DiagnosticModel>.Success(response));
            }

            return Ok(ApiResponse<DiagnosticModel>.Fail("Entity not found", "UserId"));
        }
    }
}
