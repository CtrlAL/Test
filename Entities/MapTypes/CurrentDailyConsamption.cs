namespace Entities.MapTypes
{
    public class CurrentDailyConsamption
    {
        public int Id { get; set; }
        public IEnumerable<CurrentNutrientConsumption> Nutrient { get; set; } = Array.Empty<CurrentNutrientConsumption>();
    }
}
