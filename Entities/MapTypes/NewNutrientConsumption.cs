namespace Entities.MapTypes
{
	public class NewNutrientConsumption
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float CurrentCount { get; set; }
		public float FromSuggestionCount { get; set; }
		public float FromNutrition { get; set; }

		public NewNutrientConsumption(NutrientConsumption currentNutrientConsamption, Recommendation recomdendation, NutrientContains? productNutrientContains)
		{
			var productNutrientContainCount = productNutrientContains != null ? productNutrientContains.Count : 0;
			var nededNutrition = recomdendation.RecommendedCount - currentNutrientConsamption.Count - productNutrientContainCount;

			Id = currentNutrientConsamption.Id;
			Name = currentNutrientConsamption.Nutrient.Name;
			CurrentCount = currentNutrientConsamption.Count;
			FromSuggestionCount = productNutrientContainCount;
			FromNutrition = nededNutrition > 0 ? nededNutrition : 0;
		}
	}
}
