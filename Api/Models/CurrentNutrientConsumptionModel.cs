using System.ComponentModel;

namespace Api.Models
{
	public class CurrentNutrientConsumptionModel
	{
		public int Id { get; set; }
		public int Name { get; set; }
		public float CurrentCount { get; set; }
		public float NormCount { get; set; }

		[Description("Deficiency Diagram")]
		public float CurrentPercent { get; set; }

		[Description("Deficiency Diagram")]
		public float NormDeviationPercent { get; set; }
		public bool InDeficiency { get; set; }
	}
}
