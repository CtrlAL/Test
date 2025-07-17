using BL.Services.Interfaces;
using DAL.Services.Interfaces;
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

		public ValueTask<CurrentDailyConsamption> GetByUserId(int diagnosticId)
		{
			return _mapper.GetByUserId(diagnosticId);
		}
	}
}
