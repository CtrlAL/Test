using Entities;
using Filters;

namespace DAL.EF.Interfaces
{
    public interface INutrientConsumptionRepository : IRepository<NutrientConsumption, int, NutrientConsumptionFilter>
    {
    }
}
