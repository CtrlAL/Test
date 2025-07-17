using Api.Models;
using BL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OuterSourceIntegrationController : ControllerBase
    {
        private readonly IPersonalSuggestionBL _personalSuggestionBL;
        private readonly ICurrentDailyConsumptionBL _currentDailyConsumptionBL;
        private readonly INewDailyConsumptionBL _newDailyConsumptionBL;

        public OuterSourceIntegrationController(IPersonalSuggestionBL personalSuggestionBL,
            INewDailyConsumptionBL newDailyConsumptionBL,
            ICurrentDailyConsumptionBL currentDailyConsumptionBL)
        {
            _personalSuggestionBL = personalSuggestionBL;
            _currentDailyConsumptionBL = currentDailyConsumptionBL;
            _newDailyConsumptionBL = newDailyConsumptionBL;
        }

        [HttpPost("get-current-consumption/{userId}")]
        public async Task<ActionResult<int>> GetCurrent(IFormFile jsonFile)
        {
            if (jsonFile.ContentType != "application/json") 
            {
                return BadRequest("Wrong file type");
            }


            return Ok(4);
        }
    }
}
