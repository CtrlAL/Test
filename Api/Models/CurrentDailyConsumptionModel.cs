using Entities.MapTypes;

namespace Api.Models
{
	public class CurrentDailyConsumptionModel
	{
		public int Id { get; set; }
		public IEnumerable<CurrentNutrientConsumptionModel> Nutrient { get; set; } = Array.Empty<CurrentNutrientConsumptionModel>();

		public static CurrentDailyConsumptionModel FromEntity(CurrentDailyConsamption entity)
		{
			return new CurrentDailyConsumptionModel
			{
				Id = entity.Id,
				Nutrient = entity.Nutrient.Select(CurrentNutrientConsumptionModel.FromEntity)
			};
		}
	}
}
