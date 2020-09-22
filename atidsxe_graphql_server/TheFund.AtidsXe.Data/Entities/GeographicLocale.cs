using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class GeographicLocale
    {
        public GeographicLocale()
        {
            FileReference = new HashSet<FileReference>();
        }

        public int GeographicLocaleId { get; set; }

        public string LocaleName { get; set; }

        public string LocaleAbbreviation { get; set; }

        public int GeographicLocaleTypeId { get; set; }

        public int? ParentGeographicLocaleId { get; set; }

        public virtual ICollection<FileReference> FileReference { get; set; }
    }
}