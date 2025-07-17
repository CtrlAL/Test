using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class NutritionQualityAssessmentController : ControllerBase
	{
		private readonly ILogger<NutritionQualityAssessmentController> _logger;

		public NutritionQualityAssessmentController(ILogger<NutritionQualityAssessmentController> logger)
		{
			_logger = logger;
		}

		[HttpGet("get-current-consumption/{userId}")]
		public async Task<ActionResult<CurrentDailyConsumptionModel>> GetCurrent([FromRoute] int userId)
		{


			return Ok(new());
		}

		[HttpGet("get-new-consumption/{userId}")]
		public async Task<ActionResult<NewNutrientConsumptionModel>> GetNew([FromRoute] int userId)
		{


			return Ok(new());
		}

		[HttpGet("get-suggestion/{userId}")]
		public async Task<ActionResult<NewNutrientConsumptionModel>> GetSuggestion([FromRoute] int userId)
		{

			return Ok(new());
		}
	}
}
