namespace Entities.MapTypes
{
	public class NewDailyConsumption
	{
		public int Id { get; set; }
		public IEnumerable<NewNutrientConsumption> Nutrient { get; set; } = Array.Empty<NewNutrientConsumption>();
	}
}
