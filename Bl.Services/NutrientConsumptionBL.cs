using BL.Services.Interfaces;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace BL.Services
{
    public class NutrientConsumptionBL : INutrientConsumptionBL
    {
        private readonly INutrientConsumptionRepository _repository;

        public NutrientConsumptionBL(INutrientConsumptionRepository repository)
        {
            _repository = repository;
        }

        public Task AddAsync(NutrientConsumption entity)
        {
            return _repository.AddAsync(entity);
        }

        public Task DeleteAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public ValueTask<NutrientConsumption> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<IList<NutrientConsumption>> GetByIdFilter(NutrientConsumptionFilter filter)
        {
            return _repository.GetByIdFilter(filter);
        }

        public Task UpdateAsync(NutrientConsumption entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public Task UpdateListAsync(IList<NutrientConsumption> entities)
        {
            return _repository.UpdateListAsync(entities);
        }

        public Task AddListAsync(IList<NutrientConsumption> entities)
        {
            return _repository.AddListAsync(entities);
        }
    }
}
