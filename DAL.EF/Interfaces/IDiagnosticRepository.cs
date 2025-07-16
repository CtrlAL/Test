using Entities;

namespace DAL.EF.Interfaces
{
    public interface IDiagnosticRepository : IRepository<Diagnostic, int, DiagnosticRepository>
    {
    }
}
