namespace BL.Services.Interfaces
{
	public interface IGetConsamption<TGet>
	{
		ValueTask<TGet> GetByUserId(int userId);
	}
}
