namespace Filters
{
    public class PersonalSuggestionFilter : AbstractFilter
    {
        public int? DiagnotsitcId { get; set; }
        public int? UserId { get; set; }
        public int? NutrientId { get; set; }

        public PersonalSuggestionFilter() { }
        public PersonalSuggestionFilter(int startIndex = 0, int? objectsCount = null,
            int? userId = null,
            int? nutrientId = null,
            int? diagnosticId = null) : base(startIndex, objectsCount)
        {
            UserId = userId;
            DiagnotsitcId = diagnosticId;
            NutrientId = nutrientId;
        }
    }
}
