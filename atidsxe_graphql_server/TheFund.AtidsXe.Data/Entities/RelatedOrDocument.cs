namespace TheFund.AtidsXe.Data.Entities
{
    public partial class RelatedOrDocument
    {
        public int SearchedOrDocumentId { get; set; }

        public int RelatedOrDocumentId { get; set; }

        public virtual OfficialRecordDocument RelatedOrDocumentNavigation { get; set; }

        public virtual OfficialRecordDocument SearchedOrDocument { get; set; }
    }
}