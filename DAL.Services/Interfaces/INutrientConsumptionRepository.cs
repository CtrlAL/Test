using Entities;
using Filters;

namespace DAL.Services.Interfaces
{
    public interface INutrientConsumptionRepository : IRepository<NutrientConsumption, int, NutrientConsumptionFilter>
    {
    }
}
