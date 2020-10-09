using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class GeographicLocaleType
    {
        public GeographicLocaleType()
        {
            GeographicLocale = new HashSet<GeographicLocale>();
        }

        public int GeographicLocaleTypeId { get; set; }

        [Trim]
        public string TypeName { get; set; }

        public virtual ICollection<GeographicLocale> GeographicLocale { get; set; }
    }
}