namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicySectionLegalMql
    {
        public int PolicyId { get; set; }

        public int UnplattedReferenceId { get; set; }

        public int SectionBreakdownCodeId { get; set; }

        public virtual Policy Policy { get; set; }

        public virtual SectionLegal SectionLegal { get; set; }
    }
}