using DAL.EF.Context;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace DAL.Services
{
    public class PersonalSuggestionRepository : Repository<PersonalSuggestion, int, PersonalSuggestionFilter>, IPersonalSuggestionRepository
    {
        public PersonalSuggestionRepository(AppDbContext context) : base(context)
        {
        }

		public override IQueryable<PersonalSuggestion> FilterObjects(IQueryable<PersonalSuggestion> entities, PersonalSuggestionFilter filter)
		{
			if (filter.DiagnotsitcId.HasValue)
			{
				entities = entities.Where(x => x.DiagnosticId == filter.DiagnotsitcId);
			}

			if (filter.NutrientId.HasValue)
			{
				entities = entities.Where(x => x.Products.Any(y => y.Compound.Any(x => x.NutrientId == filter.NutrientId)));
			}

			return entities;
		}
	}
}
