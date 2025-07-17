namespace Api.Models
{
	public class NewDailyConsumptionModel
	{
		public int Id { get; set; }
		public IEnumerable<NewNutrientConsumptionModel> Nutrient { get; set; } = Array.Empty<NewNutrientConsumptionModel>();
	}
}
