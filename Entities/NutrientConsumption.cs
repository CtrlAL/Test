namespace Entities
{
    public class NutrientConsumption
    {
        public int Id { get; set; }
        public int DiagnosticId { get; set; }
        public int NutrientId { get; set; }
        public float Count { get; set; }
        public Diagnostic Diagnostic { get; set; }
        public Nutrient Nutrient { get; set; }

        public NutrientConsumption(int id,
            int diagnosticId,
            int nutrientId,
            float count) 
        { 
            Id = id;
            DiagnosticId = diagnosticId;
            NutrientId = nutrientId;
            Count = count;
        }
    }
}
