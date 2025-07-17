using Entities;
using Filters;

namespace BL.Services.Interfaces
{
    public interface IDiagnosticBL : ICrud<Diagnostic, int, DiagnosticFilter>
    {
        Task<(Diagnostic? diagnostic, bool exist)> TryGetByUserId(int userId);
    }
}
