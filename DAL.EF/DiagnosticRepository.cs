using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;
using Filters;

namespace DAL.EF
{
    public class DiagnosticRepository : Repository<Diagnostic, int, DiagnosticFilter>, IDiagnosticRepository
    {
        public DiagnosticRepository(AppDbContext context) : base(context)
        {
        }

        protected override IQueryable<Diagnostic> FilterObjects(IQueryable<Diagnostic> entities, DiagnosticFilter filter)
        {
            return entities;
        }
    }
}
