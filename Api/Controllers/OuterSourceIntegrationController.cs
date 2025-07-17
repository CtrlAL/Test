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
        public async Task<ActionResult<int>> GetCurrent(IFormFile jsonFile, [FromRoute] int userId)
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

            using (var reader = new StreamReader(jsonFile.OpenReadStream()))
            {
                string json = await reader.ReadToEndAsync();
                var objects = JsonConvert.DeserializeObject<NutrientConsumption>(json);

                if (result.exist)
                {
                    
                }
                else
                {

                }
            }

            return Ok(4);
        }
    }
}
