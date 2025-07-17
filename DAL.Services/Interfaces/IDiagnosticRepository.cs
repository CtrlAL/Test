using Entities;
using Filters;

namespace DAL.Services.Interfaces
{
    public interface IDiagnosticRepository : IRepository<Diagnostic, int, DiagnosticFilter>
    {
    }
}
