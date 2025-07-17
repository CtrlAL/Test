using Entities;
using Filters;

namespace DAL.EF.Interfaces
{
    public interface INutrientRepository : IRepository<Nutrient, int, NutrientFilter>
    {
    }
}
