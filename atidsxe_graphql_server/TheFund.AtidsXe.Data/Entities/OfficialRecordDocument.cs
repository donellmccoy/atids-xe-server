using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class OfficialRecordDocument
    {
        public OfficialRecordDocument()
        {
            CertificationRangeFromOrDocuments = new HashSet<CertificationRange>();
            CertificationRangeToOrDocuments = new HashSet<CertificationRange>();
            RelatedCaseNumbers = new HashSet<RelatedCaseNumber>();
            RelatedOrDocumentRelatedOrDocumentNavigations = new HashSet<RelatedOrDocument>();
            RelatedOrDocumentSearchedOrDocuments = new HashSet<RelatedOrDocument>();
            RelatedTaxFolios = new HashSet<RelatedTaxFolio>();
            TitleEventDocuments = new HashSet<TitleEventDocument>();
        }

        public int OfficialRecordDocumentId { get; set; }

        public int? GeographicLocaleId { get; set; }

        public virtual GeographicLocale GeographicLocale { get; set; }

        public virtual BookPageReference BookPageReference { get; set; }

        public virtual OrDocumentInformation OrDocumentInformation { get; set; }

        public virtual PropertyAddress PropertyAddress { get; set; }

        public virtual YearNumberReference YearNumberReference { get; set; }

        public virtual ICollection<CertificationRange> CertificationRangeFromOrDocuments { get; set; }

        public virtual ICollection<CertificationRange> CertificationRangeToOrDocuments { get; set; }

        public virtual ICollection<RelatedCaseNumber> RelatedCaseNumbers { get; set; }

        public virtual ICollection<RelatedOrDocument> RelatedOrDocumentRelatedOrDocumentNavigations { get; set; }

        public virtual ICollection<RelatedOrDocument> RelatedOrDocumentSearchedOrDocuments { get; set; }

        public virtual ICollection<RelatedTaxFolio> RelatedTaxFolios { get; set; }

        public virtual ICollection<TitleEventDocument> TitleEventDocuments { get; set; }
    }
}