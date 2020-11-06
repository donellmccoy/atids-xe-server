using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class CaseNumberReference
    {
        public CaseNumberReference()
        {
            RelatedCaseNumber = new HashSet<RelatedCaseNumber>();
        }

        public int CaseNumberReferenceId { get; set; }

        [Trim]
        public string Source { get; set; }

        public int RecordingYear { get; set; }

        public int RecordingNumber { get; set; }

        [Trim]
        public string Suffix { get; set; }

        [Trim]
        public string SeriesCode { get; set; }

        public int? GeographicLocaleId { get; set; }

        public virtual GeographicLocale GeographicLocale { get; set; }

        public virtual ICollection<RelatedCaseNumber> RelatedCaseNumber { get; set; }
    }
}