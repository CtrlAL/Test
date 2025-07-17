using BL.Services.Interfaces;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace BL.Services
{
	public class PersonalSuggestionBL : IPersonalSuggestionBL
	{
		private readonly IPersonalSuggestionRepository _repository;

		public PersonalSuggestionBL(IPersonalSuggestionRepository repository)
		{
			_repository = repository;
		}

		public Task<int> AddAsync(PersonalSuggestion entity)
		{
			return _repository.AddAsync(entity);
		}

		public Task DeleteAsync(int id)
		{
			return _repository.DeleteAsync(id);
		}

		public ValueTask<PersonalSuggestion> GetByIdAsync(int id)
		{
			return _repository.GetByIdAsync(id);
		}

		public Task<IList<PersonalSuggestion>> GetByIdFilter(PersonalSuggestionFilter filter)
		{
			return _repository.GetByIdFilter(filter);
		}

		public Task UpdateAsync(PersonalSuggestion entity)
		{
			return _repository.UpdateAsync(entity);
		}

        public Task UpdateListAsync(IList<PersonalSuggestion> entities)
        {
            return _repository.UpdateListAsync(entities);
        }

        public Task<IList<int>> AddListAsync(IList<PersonalSuggestion> entities)
        {
            return _repository.AddListAsync(entities);
        }
    }
}
