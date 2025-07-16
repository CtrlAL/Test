using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    public class DiagnosticFilter : AbstractFilter
    {
        public int? UserId { get; set; }

        public DiagnosticFilter() { }
        public DiagnosticFilter(int startIndex = 0, int? objectsCount = null, int? userId = null) : base(startIndex, objectsCount)
        {
            UserId = userId;
        }
    }
}
