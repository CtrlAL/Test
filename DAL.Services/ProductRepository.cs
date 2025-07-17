using DAL.EF.Context;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace DAL.Services
{
    public class ProductRepository : Repository<Product, int, ProductFilter>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

		public override IQueryable<Product> FilterObjects(IQueryable<Product> entities, ProductFilter filter)
        {
            if (filter.NutrientId.HasValue)
            {
                entities = entities.Where(x => x.Compound.Any(y => y.NutrientId == filter.NutrientId));
            }

            return entities;
        }
    }
}
