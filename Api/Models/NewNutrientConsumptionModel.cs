using System.ComponentModel;
using Entities.MapTypes;

namespace Api.Models
{
	public class NewNutrientConsumptionModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float CurrentCount { get; set; }
		public float FromSuggestionCount { get; set; }
		public float FromNutrition { get; set; }

		[Description("Deficiency Diagram")]
		public float CurrentPercent { get; set; }
		[Description("Deficiency Diagram")]
		public float FromSuggestionPercent { get; set; }
		[Description("Deficiency Diagram")]
		public float FromNutritionPercent { get; set; }

		public static NewNutrientConsumptionModel FromEntity(NewNutrientConsumption entity)
		{
			var sum = entity.CurrentCount + entity.FromSuggestionCount + entity.FromNutrition;

			return new NewNutrientConsumptionModel
			{
				Id = entity.Id,
				Name = entity.Name,
				CurrentCount = entity.CurrentCount,
				FromSuggestionCount = entity.FromSuggestionCount,
				FromNutrition = entity.FromNutrition,

				CurrentPercent = entity.CurrentCount / sum,
				FromSuggestionPercent = entity.FromSuggestionCount / sum,
				FromNutritionPercent = entity.FromNutrition / sum,
			};
		}
	}
}
