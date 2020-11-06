using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TaxFolioReference
    {
        public TaxFolioReference()
        {
            RelatedTaxFolio = new HashSet<RelatedTaxFolio>();
        }

        public int TaxFolioReferenceId { get; set; }

        [Trim]
        public string FolioNumber { get; set; }

        public int? GeographicLocaleId { get; set; }

        public virtual GeographicLocale GeographicLocale { get; set; }

        public virtual ICollection<RelatedTaxFolio> RelatedTaxFolio { get; set; }
    }
}