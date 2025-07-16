namespace Entities
{
    public class Diagnostic : IEntity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ICollection<NutrientConsumption> NutrientConsumptions { get; set; }

        public Diagnostic(int id,
            int userId)
        {
            Id = id;
            UserId = userId;
        }
    }
}
