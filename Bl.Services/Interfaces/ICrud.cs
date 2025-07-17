using Filters;

namespace BL.Services.Interfaces
{
	public interface ICrud<TEntity, TId, TFilter>
		where TEntity : class
		where TId : notnull
		where TFilter : AbstractFilter
	{
		ValueTask<TEntity> GetByIdAsync(TId id);
		Task<IList<TEntity>> GetByIdFilter(TFilter filter);
		Task<TId> AddAsync(TEntity entity);
		Task UpdateAsync(TEntity entity);
        Task<IList<TId>> AddListAsync(IList<TEntity> entities);
        Task UpdateListAsync(IList<TEntity> entities);
        Task DeleteAsync(TId id);
	}
}
