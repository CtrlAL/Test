using Entities;
using Filters;

namespace DAL.Services.Interfaces
{
    public interface IRecomendationRepository : IRepository<Recommendation, int, RecomendationFilter>
    {
    }
}
