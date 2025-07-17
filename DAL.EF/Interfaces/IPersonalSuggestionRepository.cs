using Entities;
using Filters;

namespace DAL.EF.Interfaces
{
    public interface IPersonalSuggestionRepository : IRepository<PersonalSuggestion, int, PersonalSuggestionFilter>
    {
    }
}
