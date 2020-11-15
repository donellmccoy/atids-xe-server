using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class YearNumberReference
    {
        public int OfficialRecordDocumentId { get; set; }

        [Trim]
        public string Source { get; set; }

        public int RecordingYear { get; set; }

        public int RecordingNumber { get; set; }

        [Trim]
        public string Suffix { get; set; }

        [Trim]
        public string SeriesCode { get; set; }

        public virtual OfficialRecordDocument OfficialRecordDocument { get; set; }
    }
}