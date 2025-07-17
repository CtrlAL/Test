namespace Entities.MapTypes
{
    public class CurrentNutrientConsumption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float CurrentCount { get; set; }
        public float NormCount { get; set; }

        public CurrentNutrientConsumption(NutrientConsumption currentConsumption, Recommendation recomdendation)
        {
            Id = currentConsumption.Id;
            Name = currentConsumption.Nutrient.Name;
            CurrentCount = currentConsumption.Count;
            NormCount = recomdendation.RecommendedCount;
        }
    }
}
