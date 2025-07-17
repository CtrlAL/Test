namespace Entities.MapTypes
{
	public class NewNutrientConsumption
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float CurrentCount { get; set; }
		public float FromSuggestionCount { get; set; }
		public float FromNutrition { get; set; }
	}
}
