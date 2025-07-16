using DAL.EF.Context;
using Entities;

namespace DAL.EF
{
    public class NutrientRepository : Repository<Nutrient, int>
    {
        public NutrientRepository(AppDbContext context) : base(context)
        {
        }
    }
}
