using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;
using Filters;

namespace DAL.EF
{
    public class NutrientRepository : Repository<Nutrient, int, NutrientFilter>, INutrientRepository
    {
        public NutrientRepository(AppDbContext context) : base(context)
        {
        }

        protected override IQueryable<Nutrient> FilterObjects(IQueryable<Nutrient> entities, NutrientFilter filter)
        {
            return entities;
        }
    }
}
