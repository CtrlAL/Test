namespace Entities
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<NutrientContains> Compound { get; set; }
		public IEnumerable<ProductPersonalSuggestion> ProductPersonalSuggestions { get; set; }
		public IEnumerable<PersonalSuggestion> PersonalSuggestions { get; set; }
    }
}
