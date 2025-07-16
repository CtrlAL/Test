using Entities;
using Filters;

namespace DAL.EF.Interfaces
{
    internal interface IPersonalSuggestionRepository : IRepository<PersonalSuggestion, int, PersonalSuggestionFilter>
    {
    }
}
