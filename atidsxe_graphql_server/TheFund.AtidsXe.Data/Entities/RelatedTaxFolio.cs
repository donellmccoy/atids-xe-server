namespace TheFund.AtidsXe.Data.Entities
{
    public partial class RelatedTaxFolio
    {
        public int OfficialRecordDocumentId { get; set; }

        public int TaxFolioReferenceId { get; set; }

        public virtual OfficialRecordDocument OfficialRecordDocument { get; set; }

        public virtual TaxFolioReference TaxFolioReference { get; set; }
    }
}