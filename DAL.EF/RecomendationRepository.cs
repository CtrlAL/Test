using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;

namespace DAL.EF
{
    public class RecomendationRepository : Repository<Recomdendation, int>, IRecomendationRepository
    {
        public RecomendationRepository(AppDbContext context) : base(context)
        {
        }
    }
}
