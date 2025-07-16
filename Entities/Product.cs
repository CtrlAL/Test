namespace Entities
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<NutrientContains> Compound { get; set; }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
