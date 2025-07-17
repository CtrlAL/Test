using BL.Services.Interfaces;
using DAL.Services.Interfaces;
using Entities.MapTypes;

namespace BL.Services
{
	public class NewDailyConsumptionBL : INewDailyConsumptionBL
	{
		private readonly INewDailyConsamptionMapper _mapper;

		public NewDailyConsumptionBL(INewDailyConsamptionMapper mapper)
		{
			_mapper = mapper;
		}

		public ValueTask<NewDailyConsamption> GetConsamption(int diagnosticId)
		{
			return _mapper.GetByIdAsync(diagnosticId);
		}
	}
}
