using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class GeographicLocale
    {
        public GeographicLocale()
        {
            FileReference = new HashSet<FileReference>();
        }

        public int GeographicLocaleId { get; set; }

        [Trim]
        public string LocaleName { get; set; }

        [Trim]
        public string LocaleAbbreviation { get; set; }

        public int GeographicLocaleTypeId { get; set; }

        public int? ParentGeographicLocaleId { get; set; }

        //public virtual GeographicLocaleType GeographicLocaleType { get; set; }

        public virtual GeographicLocale ParentGeographicLocale { get; set; }

        //public virtual ICollection<CaseNumberReference> CaseNumberReference { get; set; }

        public virtual ICollection<FileReference> FileReference { get; set; }

        public virtual ICollection<GeographicLocale> InverseParentGeographicLocale { get; set; }

        //public virtual ICollection<OfficialRecordDocument> OfficialRecordDocument { get; set; }

        //public virtual ICollection<PolicyInsuredDocument> PolicyInsuredDocument { get; set; }

        public virtual ICollection<Search> Searches { get; set; }

        //public virtual ICollection<TaxFolioReference> TaxFolioReference { get; set; }
    }
}