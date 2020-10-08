using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class OfficialRecordDocument
    {
        public OfficialRecordDocument()
        {
            CertificationRangeFromOrDocument = new HashSet<CertificationRange>();
            CertificationRangeToOrDocument = new HashSet<CertificationRange>();
            RelatedCaseNumber = new HashSet<RelatedCaseNumber>();
            RelatedOrDocumentRelatedOrDocumentNavigation = new HashSet<RelatedOrDocument>();
            RelatedOrDocumentSearchedOrDocument = new HashSet<RelatedOrDocument>();
            RelatedTaxFolio = new HashSet<RelatedTaxFolio>();
            TitleEventDocument = new HashSet<TitleEventDocument>();
        }

        public int OfficialRecordDocumentId { get; set; }

        public int? GeographicLocaleId { get; set; }

        public virtual GeographicLocale GeographicLocale { get; set; }

        public virtual BookPageReference BookPageReference { get; set; }

        public virtual OrDocumentInformation OrDocumentInformation { get; set; }

        public virtual PropertyAddress PropertyAddress { get; set; }

        public virtual YearNumberReference YearNumberReference { get; set; }

        public virtual ICollection<CertificationRange> CertificationRangeFromOrDocument { get; set; }

        public virtual ICollection<CertificationRange> CertificationRangeToOrDocument { get; set; }

        public virtual ICollection<RelatedCaseNumber> RelatedCaseNumber { get; set; }

        public virtual ICollection<RelatedOrDocument> RelatedOrDocumentRelatedOrDocumentNavigation { get; set; }

        public virtual ICollection<RelatedOrDocument> RelatedOrDocumentSearchedOrDocument { get; set; }

        public virtual ICollection<RelatedTaxFolio> RelatedTaxFolio { get; set; }

        public virtual ICollection<TitleEventDocument> TitleEventDocument { get; set; }
    }
}