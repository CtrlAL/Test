using Api.Models;
using BL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class NutritionQualityAssessmentController : ControllerBase
	{
		private readonly IPersonalSuggestionBL _personalSuggestionBL;
		private readonly ICurrentDailyConsumptionBL _currentDailyConsumptionBL;
		private readonly INewDailyConsumptionBL _newDailyConsumptionBL;

		public NutritionQualityAssessmentController(IPersonalSuggestionBL personalSuggestionBL, 
			INewDailyConsumptionBL newDailyConsumptionBL, 
			ICurrentDailyConsumptionBL currentDailyConsumptionBL)
		{
			_personalSuggestionBL = personalSuggestionBL;
			_currentDailyConsumptionBL = currentDailyConsumptionBL;
			_newDailyConsumptionBL = newDailyConsumptionBL;	
		}

		[HttpGet("get-current-consumption/{userId}")]
		public async Task<ActionResult<CurrentDailyConsumptionModel>> GetCurrent([FromRoute] int userId)
		{
			var result = await _currentDailyConsumptionBL.GetByUserId(userId);


			return Ok(new());
		}

		[HttpGet("get-new-consumption/{userId}")]
		public async Task<ActionResult<NewNutrientConsumptionModel>> GetNew([FromRoute] int userId)
		{
			var result = await _newDailyConsumptionBL.GetByUserId(userId);

			return Ok(new());
		}

		[HttpGet("get-suggestion/{userId}")]
		public async Task<ActionResult<NewNutrientConsumptionModel>> GetSuggestion([FromRoute] int userId)
		{
			var result = await _personalSuggestionBL.GetByIdFilter(new(userId: userId));

			return Ok(new());
		}
	}
}
