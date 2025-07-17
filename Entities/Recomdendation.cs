namespace Entities
{
    public class Recommendation : IEntity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int NutrientId { get; set; }
        public float RecommendedCount { get; set; }
        public User User { get; set; }
        public Nutrient Nutrient { get; set; }
    }
}
