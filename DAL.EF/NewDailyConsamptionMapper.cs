using DAL.EF.Interfaces;
using Entities.MapTypes;

namespace DAL.EF
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

		public async ValueTask<NewDailyConsamption> GetByIdAsync(int id)
		{
			var consumptions = _consumptionRepository.GetDbObjects();
			var recomendations = _recomendationRepository.GetDbObjects();
			var nutrientContains = _productRepository.GetDbObjects()
				.Where(x => x.PersonalSuggestions.Any(x => x.DiagnosticId == id))
				.SelectMany(x => x.Compound);

			var query = consumptions
			.Where(c => c.DiagnosticId == id)
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
				(cr, p) => new NewNutrientConsumption(cr.Consumption, cr.Recommendation, p)
			);

			return new NewDailyConsamption
			{
				Id = id,
				Nutrient = query,
			};
		}
	}
}
