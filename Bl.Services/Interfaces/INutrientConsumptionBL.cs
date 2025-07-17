using Entities;
using Filters;

namespace BL.Services.Interfaces
{
    public interface INutrientConsumptionBL : ICrud<NutrientConsumption, int, NutrientConsumptionFilter>
    {
    }
}
