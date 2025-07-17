using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;

namespace Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class NutritionQualityAssessmentController : ControllerBase
	{
		private readonly ILogger<WeatherForecastController> _logger;

		public NutritionQualityAssessmentController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get([FromRoute] int id)
		{


			return Ok();
		}
	}
}
