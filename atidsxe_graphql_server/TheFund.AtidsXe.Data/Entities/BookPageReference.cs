using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class BookPageReference
    {
        public int OfficialRecordDocumentId { get; set; }

        [Trim]
        public string Source { get; set; }

        [Trim]
        public string Book { get; set; }

        [Trim]
        public string BookSuffix { get; set; }

        [Trim]
        public string Page { get; set; }

        [Trim]
        public string PageSuffix { get; set; }

        public virtual OfficialRecordDocument OfficialRecordDocument { get; set; }
    }
}