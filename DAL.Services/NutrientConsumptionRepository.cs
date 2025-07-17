using DAL.EF.Context;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace DAL.Services
{
    public class NutrientConsumptionRepository : Repository<NutrientConsumption, int, NutrientConsumptionFilter>, INutrientConsumptionRepository
    {
        public NutrientConsumptionRepository(AppDbContext context) : base(context)
        {
        }

		public override IQueryable<NutrientConsumption> FilterObjects(IQueryable<NutrientConsumption> entities, NutrientConsumptionFilter filter)
        {
			if (filter.DiagnotsitcId.HasValue)
			{
				entities = entities.Where(x => x.DiagnosticId == filter.DiagnotsitcId);
			}

			if (filter.UserId.HasValue)
			{
				entities = entities.Where(x => x.Diagnostic.UserId == filter.UserId);
			}

			if (filter.NutrientId.HasValue)
			{
				entities = entities.Where(x => x.NutrientId == filter.NutrientId);
			}

			return entities;
        }
    }
}
