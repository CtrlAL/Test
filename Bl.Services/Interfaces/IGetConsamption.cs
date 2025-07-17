namespace BL.Services.Interfaces
{
	public interface IGetConsamption<TGet>
	{
		ValueTask<TGet> GetConsamption(int diagnosticId);
	}
}
