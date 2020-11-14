using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class GeographicLocale
    {
        public GeographicLocale()
        {
            FileReferences = new HashSet<FileReference>();
        }

        public int GeographicLocaleId { get; set; }

        [Trim]
        public string LocaleName { get; set; }

        [Trim]
        public string LocaleAbbreviation { get; set; }

        public int GeographicLocaleTypeId { get; set; }

        public int? ParentGeographicLocaleId { get; set; }

        public virtual GeographicLocaleType GeographicLocaleType { get; set; }

        public virtual GeographicLocale ParentGeographicLocale { get; set; }

        public virtual ICollection<CaseNumberReference> CaseNumberReferences { get; set; }

        public virtual ICollection<FileReference> FileReferences { get; set; }

        public virtual ICollection<GeographicLocale> InverseParentGeographicLocale { get; set; }

        public virtual ICollection<OfficialRecordDocument> OfficialRecordDocuments { get; set; }

        public virtual ICollection<PolicyInsuredDocument> PolicyInsuredDocuments { get; set; }

        public virtual ICollection<Search> Searches { get; set; }

        public virtual ICollection<TaxFolioReference> TaxFolioReferences { get; set; }
    }
}