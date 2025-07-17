using Entities;
using Filters;

namespace DAL.EF.Interfaces
{
    public interface IProductRepository : IRepository<Product, int, ProductFilter>
    {
    }
}
