namespace TheFund.AtidsXe.Data.Entities
{
    public partial class RelatedCaseNumber
    {
        public int OfficialRecordDocumentId { get; set; }

        public int CaseNumberReferenceId { get; set; }

        public virtual CaseNumberReference CaseNumberReference { get; set; }

        public virtual OfficialRecordDocument OfficialRecordDocument { get; set; }
    }
}