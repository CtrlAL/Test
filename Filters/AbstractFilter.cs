namespace Filters
{
    public abstract class AbstractFilter
    {
        public int StartIndex { get; set; }
        public int? Count { get; set; }

        public AbstractFilter(int startIndex = 0, int? count = null)
        {
            StartIndex = startIndex;
            Count = count;
        }
    }
}
