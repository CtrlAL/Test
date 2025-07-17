namespace DAL.EF
{
    public interface IRepository<T, TId, TFilter> 
        where T : class
        where TId : notnull
        where TFilter : class
    {
        ValueTask<T> GetByIdAsync(TId id);
        Task<IList<T>> GetByIdFilter(TFilter filter);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(TId id);
        internal IQueryable<T> GetDbObjects();
	}
}
