using Entities;
using Filters;

namespace DAL.Services.Interfaces
{
    public interface IPersonalSuggestionRepository : IRepository<PersonalSuggestion, int, PersonalSuggestionFilter>
    {
    }
}
