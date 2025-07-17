using Entities;
using Filters;

namespace DAL.Services.Interfaces
{
    public interface INutrientRepository : IRepository<Nutrient, int, NutrientFilter>
    {
    }
}
