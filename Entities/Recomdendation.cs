namespace Entities
{
    public class Recomdendation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int NutrientId { get; set; }
        public float RecomendedCount { get; set; }
        public User User { get; set; }
        public Nutrient Nutrient { get; set; }

        public Recomdendation(int id, 
            int userId,
            float recomdendedCount
        )
        {
            Id = id;
            UserId = userId;
            RecomendedCount = recomdendedCount;
        }
    }
}
