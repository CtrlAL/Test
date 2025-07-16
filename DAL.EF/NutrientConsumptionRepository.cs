using DAL.EF.Context;
using Entities;

namespace DAL.EF
{
    public class NutrientConsumptionRepository : Repository<NutrientConsumption, int>
    {
        public NutrientConsumptionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
