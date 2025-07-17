using DAL.EF.Interfaces;
using Entities.MapTypes;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
	public class CurrentDailyConsamptionMapper : ICurrentDailyConsamptionMapper
	{
		private readonly INutrientConsumptionRepository _consumptionRepository;
		private readonly IRecomendationRepository _recomendationRepository;

		public CurrentDailyConsamptionMapper(INutrientConsumptionRepository nutrientConsumptionRepository,
			IRecomendationRepository recomendationRepository)
		{
			_consumptionRepository = nutrientConsumptionRepository;
			_recomendationRepository = recomendationRepository;
		}

		public async ValueTask<CurrentDailyConsamption> GetByIdAsync(int id)
		{
			var consumptions = _consumptionRepository.GetDbObjects();
			var recomendations = _recomendationRepository.GetDbObjects();

			var query = consumptions
			.Where(c => c.DiagnosticId == id)
			.Join(
				recomendations,
				c => c.NutrientId,
				r => r.NutrientId,
				(c, r) => new CurrentNutrientConsumption(c, r)
			);

			return new CurrentDailyConsamption
			{
				Id = id,
				Nutrient = query,
			};
		}
	}
}
