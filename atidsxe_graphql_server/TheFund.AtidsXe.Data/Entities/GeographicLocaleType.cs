using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class GeographicLocaleType
    {
        public GeographicLocaleType()
        {
            GeographicLocales = new HashSet<GeographicLocale>();
        }

        public int GeographicLocaleTypeId { get; set; }

        [Trim]
        public string TypeName { get; set; }

        public virtual ICollection<GeographicLocale> GeographicLocales { get; set; }
    }
}