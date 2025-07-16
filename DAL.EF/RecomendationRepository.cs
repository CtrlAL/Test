using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;
using Filters;

namespace DAL.EF
{
    public class RecomendationRepository : Repository<Recomdendation, int, RecomendationFilter>, IRecomendationRepository
    {
        public RecomendationRepository(AppDbContext context) : base(context)
        {
        }

        protected override IQueryable<Recomdendation> FilterObjects(IQueryable<Recomdendation> entities, RecomendationFilter filter)
        {
            return entities;
        }
    }
}
