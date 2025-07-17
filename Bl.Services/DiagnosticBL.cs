using BL.Services.Interfaces;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace BL.Services
{
    public class DiagnosticBL : IDiagnosticBL
    {
        private readonly IDiagnosticRepository _repository;

        public DiagnosticBL(IDiagnosticRepository repository)
        {
            _repository = repository;
        }

        public Task<int> AddAsync(Diagnostic entity)
        {
            return _repository.AddAsync(entity);
        }

        public Task DeleteAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public ValueTask<Diagnostic> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<IList<Diagnostic>> GetByIdFilter(DiagnosticFilter filter)
        {
            return _repository.GetByIdFilter(filter);
        }

        public async Task<(Diagnostic? diagnostic, bool exist)> TryGetByUserId(int userId)
        {
            var diagnostic = (await _repository.GetByIdFilter(new(userId: userId))).FirstOrDefault();

            return (diagnostic, diagnostic != null);
        }

        public Task UpdateAsync(Diagnostic entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public Task UpdateListAsync(IList<Diagnostic> entities)
        {
            return _repository.UpdateListAsync(entities);
        }

        public Task<IList<int>> AddListAsync(IList<Diagnostic> entities)
        {
            return _repository.AddListAsync(entities);
        }
    }
}
