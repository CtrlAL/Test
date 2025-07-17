namespace Api.Models
{
	public class PersonalSuggestionModel
	{
		public int Id { get; set; }
		public IEnumerable<ProductModel> ProductModel { get; set; } = Array.Empty<ProductModel>();
	}
}
