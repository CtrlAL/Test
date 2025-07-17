using Entities.MapTypes;

namespace Api.Models
{
	public class NewDailyConsumptionModel
	{
		public int Id { get; set; }
		public IEnumerable<NewNutrientConsumptionModel> Nutrient { get; set; } = Array.Empty<NewNutrientConsumptionModel>();

		public static NewDailyConsumptionModel FromEntity(NewDailyConsumption entity)
		{
			return new NewDailyConsumptionModel
			{
				Id = entity.Id,
				Nutrient = entity.Nutrient.Select(NewNutrientConsumptionModel.FromEntity)
			};
		}
	}
}
