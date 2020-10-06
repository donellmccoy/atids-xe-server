namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventSectionLegalMql
    {
        public int SectionBreakdownCodeId { get; set; }
        public int UnplattedReferenceId { get; set; }
        public int TitleEventId { get; set; }

        public virtual SectionLegal SectionLegal { get; set; }
        public virtual TitleEvent TitleEvent { get; set; }
    }
}