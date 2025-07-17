namespace Entities.MapTypes
{
	public class NewNutrientConsumption
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float CurrentCount { get; set; }
		public float FromSuggestionCount { get; set; }
		public float FromNutrition { get; set; }

		public NewNutrientConsumption(NutrientConsumption currentNutrientConsamption, Recomdendation recomdendation, NutrientContains productNutrientContains)
		{
			var nededNutrition = recomdendation.RecomendedCount - currentNutrientConsamption.Count - productNutrientContains.Count;

			Id = currentNutrientConsamption.Id;
			Name = currentNutrientConsamption.Nutrient.Name;
			CurrentCount = currentNutrientConsamption.Count;
			FromSuggestionCount = productNutrientContains.Count;
			FromNutrition = nededNutrition > 0 ? nededNutrition : 0;
		}
	}
}
