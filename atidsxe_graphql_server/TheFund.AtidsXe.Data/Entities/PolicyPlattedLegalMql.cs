namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyPlattedLegalMql
    {
        public int PolicyId { get; set; }
        public int PlatReferenceId { get; set; }
        public int SubdivisionLevelId { get; set; }

        public virtual PlattedLegal PlattedLegal { get; set; }
        public virtual Policy Policy { get; set; }
    }
}