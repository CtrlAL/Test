using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;
using Filters;

namespace DAL.EF
{
    public class NutrientConsumptionRepository : Repository<NutrientConsumption, int, NutrientConsumptionFilter>, INutrientConsumptionRepository
    {
        public NutrientConsumptionRepository(AppDbContext context) : base(context)
        {
        }

        protected override IQueryable<NutrientConsumption> FilterObjects(IQueryable<NutrientConsumption> entities, NutrientConsumptionFilter filter)
        {
            return entities;
        }
    }
}
