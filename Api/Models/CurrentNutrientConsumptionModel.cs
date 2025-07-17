using Entities.MapTypes;
using System.ComponentModel;

namespace Api.Models
{
	public class CurrentNutrientConsumptionModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float CurrentCount { get; set; }
		public float NormCount { get; set; }

		[Description("Deficiency Diagram")]
		public float CurrentPercent { get; set; }

		[Description("Deficiency Diagram")]
		public float NormDeviationPercent { get; set; }
		public bool InDeficiency { get; set; }

		public static CurrentNutrientConsumptionModel FromEntity(CurrentNutrientConsumption entity)
		{
			return new CurrentNutrientConsumptionModel
			{
				Id = entity.Id,
				Name = entity.Name,
				CurrentCount = entity.CurrentCount,
				NormCount = entity.NormCount,

				CurrentPercent = entity.CurrentCount / entity.NormCount,
				NormDeviationPercent = (entity.NormCount - entity.CurrentCount) / entity.NormCount,

				InDeficiency = entity.CurrentCount < entity.NormCount
			};
		}
	}
}
