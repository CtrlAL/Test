namespace Entities
{
    public class NutrientConsumption : IEntity<int>
    {
        public int Id { get; set; }
        public int DiagnosticId { get; set; }
        public int NutrientId { get; set; }
        public float Count { get; set; }
        public Diagnostic Diagnostic { get; set; }
        public Nutrient Nutrient { get; set; }
    }
}
