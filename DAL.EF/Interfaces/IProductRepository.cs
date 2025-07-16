using Entities;
using Filters;

namespace DAL.EF.Interfaces
{
    internal interface IProductRepository : IRepository<Product, int, ProductFilter>
    {
    }
}
