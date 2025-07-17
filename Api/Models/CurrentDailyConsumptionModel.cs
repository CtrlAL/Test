namespace Api.Models
{
	public class CurrentDailyConsumptionModel
	{
		public int Id { get; set; }
		public IEnumerable<CurrentNutrientConsumptionModel> Nutrient { get; set; } = Array.Empty<CurrentNutrientConsumptionModel>();
	}
}
