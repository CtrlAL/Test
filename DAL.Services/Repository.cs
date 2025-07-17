using CustomExceptions;
using DAL.EF.Context;
using Entities;
using Filters;
using Microsoft.EntityFrameworkCore;

namespace DAL.Services
{
    public abstract class Repository<T, TId, TFilter> : IRepository<T, TId, TFilter>
        where T : class, IEntity<TId>
        where TId : notnull
        where TFilter : AbstractFilter
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
            return await _dbSet.FindAsync(id) ?? throw new EntityNotFound("Entity not found");
        }

        public virtual async Task<TId> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
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

        public IQueryable<T> GetDbObjects()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<IList<T>> GetByIdFilter(TFilter filter) 
        {
            var objects = GetDbObjects();

            objects = FilterObjects(objects, filter)
                .Skip(filter.StartIndex);

            if (filter.Count.HasValue)
            {
                objects.Take(filter.Count.Value);
            }

            return await objects.ToListAsync();
        }

		public abstract IQueryable<T> FilterObjects(IQueryable<T> entities, TFilter filter);

        public async Task<IList<TId>> AddListAsync(IList<T> entity)
        {
            await _dbSet.AddRangeAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Select(x => x.Id).ToList();
        }

        public async Task UpdateListAsync(IList<T> entity)
        {
            _dbSet.AttachRange(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
