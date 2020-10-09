namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventDocument
    {
        public int TitleEventId { get; set; }

        public int OfficialRecordDocumentId { get; set; }

        public virtual OfficialRecordDocument OfficialRecordDocument { get; set; }

        public virtual TitleEvent TitleEvent { get; set; }
    }
}