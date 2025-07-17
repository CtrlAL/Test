using Entities;

namespace Api.Models
{
	public class PersonalSuggestionModel
	{
		public int Id { get; set; }
		public IEnumerable<ProductModel> Products { get; set; }

		public static PersonalSuggestionModel FromEntity(PersonalSuggestion personalSuggestion)
		{
			return new PersonalSuggestionModel
			{
				Id = personalSuggestion.Id,
				Products = personalSuggestion.Products.Select(ProductModel.FromEntity)
			};
		}
    }
}
