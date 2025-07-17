using Entities;

namespace DAL.EF.Interfaces
{
	public interface IEntityMaper<TMap, TEnity, TId>
		where TMap : class
		where TEnity : class, IEntity<TId>
		where TId : notnull
	{
		ValueTask<TMap> GetByIdAsync(TId id);
	}
}
