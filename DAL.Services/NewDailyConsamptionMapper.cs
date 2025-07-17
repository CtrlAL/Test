using DAL.Services.Interfaces;
using Entities.MapTypes;
using Microsoft.EntityFrameworkCore;

namespace DAL.Services
{
	public class NewDailyConsamptionMapper : INewDailyConsamptionMapper
	{
		private readonly IDiagnosticRepository _diagnosticRepository;
		private readonly INutrientConsumptionRepository _consumptionRepository;
		private readonly IProductRepository _productRepository;
		private readonly IRecomendationRepository _recomendationRepository;

		public NewDailyConsamptionMapper(INutrientConsumptionRepository nutrientConsumptionRepository,
			IRecomendationRepository recomendationRepository,
			IProductRepository productRepository)
		{
			_consumptionRepository = nutrientConsumptionRepository;
			_recomendationRepository = recomendationRepository;
			_productRepository = productRepository;
		}

		public async ValueTask<NewDailyConsumption> GetByUserId(int id)
		{
			var consumptions = _consumptionRepository.GetDbObjects();
			var recomendations = _recomendationRepository.GetDbObjects();
			var nutrientContains = _productRepository.GetDbObjects()
				.Where(x => x.PersonalSuggestions.Any(x => x.DiagnosticId == id))
				.SelectMany(x => x.Compound);

			var query = await consumptions
			.Where(c => c.Diagnostic.UserId == id)
			.Join(
				recomendations,
				c => c.NutrientId,
				r => r.NutrientId,
				(c, r) => new { Consumption = c, Recommendation = r }
			)
			.Join(
				nutrientContains,
				cr => cr.Recommendation.NutrientId,
				cp => cp.NutrientId,
				(cr, p) => new NewNutrientConsumption
				{
                    Id = cr.Consumption.Id,
                    Name = cr.Consumption.Nutrient.Name,
                    CurrentCount = cr.Consumption.Count,
                    FromSuggestionCount = p != null ? p.Count : 0,
                    FromNutrition = Math.Max(cr.Recommendation.RecommendedCount - cr.Consumption.Count - (p != null ? p.Count : 0),0)
                }
            ).ToListAsync();

			return new NewDailyConsumption
			{
				Id = id,
				Nutrient = query,
			};
		}
	}
}
