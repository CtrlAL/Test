namespace Filters
{
    public class ProductFilter : AbstractFilter
    {
        public int? NutrientId { get; set; }

        public ProductFilter() { }
        public ProductFilter(int startIndex = 0, int? objectsCount = null, int? nutrientId = null) : base(startIndex, objectsCount)
        {
            NutrientId = nutrientId;
        }
    }
}
