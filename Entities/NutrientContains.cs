namespace Entities
{
    public class NutrientContains : IEntity<int>
    {
        public int Id { get; set; }
        public int NutrientId { get; set; }
        public int ProductId { get; set; }
        public float Count { get; set; }
        public Product Product { get; set; }
        public Nutrient Nutrient { get; set; }
    }
}
