using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;
using Filters;

namespace DAL.EF
{
    public class PersonalSuggestionRepository : Repository<PersonalSuggestion, int, PersonalSuggestionFilter>, IPersonalSuggestionRepository
    {
        public PersonalSuggestionRepository(AppDbContext context) : base(context)
        {
        }

		protected override IQueryable<PersonalSuggestion> FilterObjects(IQueryable<PersonalSuggestion> entities, PersonalSuggestionFilter filter)
		{
			return entities;
		}
	}
}
