using System.ComponentModel;

namespace Api.Models
{
	public class NewNutrientConsumptionModel
	{
		public int Id { get; set; }
		public int Name { get; set; }
		public float CurrentCount { get; set; }
		public float FromSuggestionCount { get; set; }
		public float FromNutrition { get; set; }

		[Description("Deficiency Diagram")]
		public float CurrentPercent { get; set; }
		[Description("Deficiency Diagram")]
		public float FromSuggestionPercent { get; set; }
		[Description("Deficiency Diagram")]
		public float FromNutritionPercent { get; set; }
	}
}
