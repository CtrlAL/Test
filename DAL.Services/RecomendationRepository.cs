using DAL.EF.Context;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace DAL.Services
{
    public class RecomendationRepository : Repository<Recomdendation, int, RecomendationFilter>, IRecomendationRepository
    {
        public RecomendationRepository(AppDbContext context) : base(context)
        {
        }

		public override IQueryable<Recomdendation> FilterObjects(IQueryable<Recomdendation> entities, RecomendationFilter filter)
        {
            return entities;
        }
    }
}
