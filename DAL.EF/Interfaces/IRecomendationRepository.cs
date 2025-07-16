using Entities;
using Filters;

namespace DAL.EF.Interfaces
{
    public interface IRecomendationRepository : IRepository<Recomdendation, int, RecomendationFilter>
    {
    }
}
