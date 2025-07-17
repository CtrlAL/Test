namespace Entities
{
	public class ProductPersonalSuggestion
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int ProductSuggestionId { get; set; }
		public Product Product { get; set; }
		public PersonalSuggestion ProductSuggestion { get; set; }
	}
}
