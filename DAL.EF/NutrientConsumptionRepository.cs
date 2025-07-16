using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;

namespace DAL.EF
{
    public class NutrientConsumptionRepository : Repository<NutrientConsumption, int>, INutrientConsumptionRepository
    {
        public NutrientConsumptionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
