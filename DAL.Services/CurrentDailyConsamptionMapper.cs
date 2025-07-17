using DAL.Services.Interfaces;
using Entities.MapTypes;
using Microsoft.EntityFrameworkCore;

namespace DAL.Services
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

		public async ValueTask<CurrentDailyConsamption> GetByUserId(int id)
		{
			var consumptions = _consumptionRepository.GetDbObjects();
			var recomendations = _recomendationRepository.GetDbObjects();

			var query = await consumptions
			.Where(c => c.Diagnostic.UserId == id)
			.Join(
				recomendations,
				c => c.NutrientId,
				r => r.NutrientId,
				(c, r) => new CurrentNutrientConsumption 
				{ 
					Id = id,
					Name = c.Nutrient.Name,
					CurrentCount = c.Count,
					NormCount = r.RecommendedCount,
				}
			)
			.ToListAsync();

			return new CurrentDailyConsamption
			{
				Id = id,
				Nutrient = query,
			};
		}
	}
}
