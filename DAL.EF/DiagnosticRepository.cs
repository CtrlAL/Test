using DAL.EF.Context;
using Entities;

namespace DAL.EF
{
    public class DiagnosticRepository : Repository<Diagnostic, int>
    {
        public DiagnosticRepository(AppDbContext context) : base(context)
        {
        }
    }
}
