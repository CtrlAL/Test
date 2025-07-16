using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;

namespace DAL.EF
{
    public class DiagnosticRepository : Repository<Diagnostic, int>, IDiagnosticRepository
    {
        public DiagnosticRepository(AppDbContext context) : base(context)
        {
        }
    }
}
