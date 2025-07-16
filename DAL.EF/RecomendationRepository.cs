using DAL.EF.Context;
using Entities;

namespace DAL.EF
{
    public class RecomendationRepository : Repository<Recomdendation, int>
    {
        public RecomendationRepository(AppDbContext context) : base(context)
        {
        }
    }
}
