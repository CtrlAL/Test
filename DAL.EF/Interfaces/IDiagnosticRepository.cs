using Entities;
using Filters;

namespace DAL.EF.Interfaces
{
    public interface IDiagnosticRepository : IRepository<Diagnostic, int, DiagnosticFilter>
    {
    }
}
