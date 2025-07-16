using Entities;

namespace DAL.EF.Interfaces
{
    public interface INutrientRepository : IRepository<Nutrient, int, NutrientRepository>
    {
    }
}
