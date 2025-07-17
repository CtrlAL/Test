using Entities;
using Filters;

namespace DAL.Services.Interfaces
{
    public interface IProductRepository : IRepository<Product, int, ProductFilter>
    {
    }
}
