using DAL.EF.Context;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace DAL.Services
{
    public class RecomendationRepository : Repository<Recommendation, int, RecomendationFilter>, IRecomendationRepository
    {
        public RecomendationRepository(AppDbContext context) : base(context)
        {
        }

		public override IQueryable<Recommendation> FilterObjects(IQueryable<Recommendation> entities, RecomendationFilter filter)
        {
            if (filter.UserId.HasValue)
            {
                entities = entities.Where(x => x.UserId == filter.UserId);
            }

			if (filter.NutrientId.HasValue)
			{
                entities = entities.Where(x => x.NutrientId == filter.NutrientId);
			}

			return entities;
        }
    }
}
