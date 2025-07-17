using DAL.EF.Interfaces;
using Entities.MapTypes;

namespace BL.Services
{
	public class NewCurrentDailyConsumptionBL : INewDailyConsamptionMapper
	{
		private readonly INewDailyConsamptionMapper _mapper;

		public NewCurrentDailyConsumptionBL(INewDailyConsamptionMapper mapper)
		{
			_mapper = mapper;
		}

		public ValueTask<NewDailyConsamption> GetByIdAsync(int diagnosticId)
		{
			return _mapper.GetByIdAsync(diagnosticId);
		}
	}
}
