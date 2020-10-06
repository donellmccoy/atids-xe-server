namespace TheFund.AtidsXe.Data.Entities
{
    public partial class AcreageSectionLegal
    {
        public int SearchId { get; set; }
        public int SectionBreakdownCodeId { get; set; }
        public int UnplattedReferenceId { get; set; }

        public virtual Search Search { get; set; }
        public virtual SectionLegal SectionLegal { get; set; }
    }
}