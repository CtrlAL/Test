using DAL.EF.Context;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace DAL.Services
{
    public class NutrientRepository : Repository<Nutrient, int, NutrientFilter>, INutrientRepository
    {
        public NutrientRepository(AppDbContext context) : base(context)
        {
        }

		public override IQueryable<Nutrient> FilterObjects(IQueryable<Nutrient> entities, NutrientFilter filter)
        {
			return entities;
        }
    }
}
