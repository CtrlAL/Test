using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;

namespace DAL.EF
{
    public class PersonalSuggestionRepository : Repository<PersonalSuggestion, int, PersonalSuggestion>, IPersonalSuggestionRepository
    {
        public PersonalSuggestionRepository(AppDbContext context) : base(context)
        {
        }

        protected override IQueryable<PersonalSuggestion> FilterObjects(IQueryable<PersonalSuggestion> entities, PersonalSuggestion filter)
        {
            return entities;
        }
    }
}
