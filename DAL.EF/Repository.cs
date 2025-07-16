using DAL.EF.Context;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class Repository<T, TId> : IRepository<T, TId>
        where T : class, IEntity<TId>
        where TId : notnull
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async ValueTask<T> GetByIdAsync(TId id)
        {
            return await _dbSet.FindAsync(id) ?? throw new InvalidOperationException("Entity not found");
        }

        public virtual async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(TId id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        protected IQueryable<T> GetDbObjects()
        {
            return _context.Set<T>().AsNoTracking();
        }
    }
}
