using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;
using Filters;

namespace DAL.EF
{
    public class ProductRepository : Repository<Product, int, ProductFilter>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        protected override IQueryable<Product> FilterObjects(IQueryable<Product> entities, ProductFilter filter)
        {
            return entities;
        }
    }
}
