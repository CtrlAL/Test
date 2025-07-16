using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;

namespace DAL.EF
{
    public class NutrientRepository : Repository<Nutrient, int>, INutrientRepository
    {
        public NutrientRepository(AppDbContext context) : base(context)
        {
        }
    }
}
