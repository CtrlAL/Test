using BL.Services.Interfaces;
using DAL.EF.Interfaces;
using Entities.MapTypes;

namespace BL.Services
{
	public class CurrentDailyConsumptionBL : ICurrentDailyConsumptionBL
	{
		private readonly ICurrentDailyConsamptionMapper _mapper;

		public CurrentDailyConsumptionBL(ICurrentDailyConsamptionMapper mapper)
		{
			_mapper = mapper;
		}

		public ValueTask<CurrentDailyConsamption> GetConsamption(int diagnosticId)
		{
			return _mapper.GetByIdAsync(diagnosticId);
		}
	}
}
