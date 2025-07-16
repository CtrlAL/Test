using Entities;

namespace DAL.EF
{
    public interface IRepository<T, TId> 
        where T : class
        where TId : notnull
    {
        ValueTask<T> GetByIdAsync(TId id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(TId id);
    }
}
