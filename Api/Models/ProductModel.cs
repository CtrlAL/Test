using Entities;

namespace Api.Models
{
	public class ProductModel
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public static ProductModel FromEntity(Product product)
		{
			return new ProductModel
			{
				Id = product.Id,
				Name = product.Name,
			};
		}
    }
}
