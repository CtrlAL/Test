using Api.Models;
using Api.Models.Response;
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
		public async Task<ActionResult<ApiResponse<CurrentDailyConsumptionModel>>> GetCurrent([FromRoute] int userId)
		{
			var result = await _currentDailyConsumptionBL.GetByUserId(userId);
			var response = CurrentDailyConsumptionModel.FromEntity(result);

            return Ok(ApiResponse<CurrentDailyConsumptionModel>.Success(response));
        }

		[HttpGet("get-new-consumption/{userId}")]
		public async Task<ActionResult<ApiResponse<NewNutrientConsumptionModel>>> GetNew([FromRoute] int userId)
		{
			var result = await _newDailyConsumptionBL.GetByUserId(userId);
            var response = NewDailyConsumptionModel.FromEntity(result);

            return Ok(ApiResponse<NewDailyConsumptionModel>.Success(response));
        }

		[HttpGet("get-suggestion/{userId}")]
		public async Task<ActionResult<ApiResponse<PersonalSuggestionModel>>> GetSuggestion([FromRoute] int userId)
		{
			var result = (await _personalSuggestionBL.GetByIdFilter(new(userId: userId))).FirstOrDefault();

			if (result != null)
			{
                var response = PersonalSuggestionModel.FromEntity(result);
                return Ok(ApiResponse<PersonalSuggestionModel>.Success(response));
            }
			else
			{
				return NotFound();
			}
		}
	}
}
