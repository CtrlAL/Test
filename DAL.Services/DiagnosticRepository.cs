using DAL.EF.Context;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace DAL.Services
{
    public class DiagnosticRepository : Repository<Diagnostic, int, DiagnosticFilter>, IDiagnosticRepository
    {
        public DiagnosticRepository(AppDbContext context) : base(context)
        {
        }

		public override IQueryable<Diagnostic> FilterObjects(IQueryable<Diagnostic> entities, DiagnosticFilter filter)
        {
            if (filter.UserId.HasValue)
            {
                entities = entities.Where(x => x.UserId == filter.UserId);
            }

            return entities;
        }
    }
}
