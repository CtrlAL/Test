namespace Entities
{
    public class PersonalSuggestion : IEntity<int>
    {
        public int Id { get ; set; }
        public int DiagnosticId { get ; set; }
        public Diagnostic Diagnostic { get; set; }
        public IEnumerable<Product> Products { get; set; }
		public IEnumerable<ProductPersonalSuggestion> ProductPersonalSuggestions { get; set; }
    }
}
