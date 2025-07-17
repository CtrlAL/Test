namespace DAL.Services.Interfaces
{
	public interface IConsumptionMapper<TMap, TUserId>
		where TMap : class
		where TUserId : notnull
	{
		ValueTask<TMap> GetByUserId(TUserId diagnosticId);
	}
}
