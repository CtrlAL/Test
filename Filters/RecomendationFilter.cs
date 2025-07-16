namespace Filters
{
    public class RecomendationFilter : AbstractFilter
    {
        public int? NutrientId { get; set; }
        public int? UserId { get; set; }

        public RecomendationFilter() { }
        public RecomendationFilter(int startIndex = 0, int? objectsCount = null, int? nutrientId = null, int? userId = null) : base(startIndex, objectsCount)
        {
            NutrientId = nutrientId;
            UserId = userId;
        }
    }
}
