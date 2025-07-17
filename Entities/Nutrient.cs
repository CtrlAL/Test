namespace Entities
{
    public class Nutrient : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Measure {  get; set; }
		public IEnumerable<NutrientConsumption> NutrientConsumptions { get; set; }
		public IEnumerable<NutrientContains> NutrientContains { get; set; }
		public IEnumerable<Product> Products { get; set; }
		public IEnumerable<Recommendation> Recommendations { get; set; }
    }
}
