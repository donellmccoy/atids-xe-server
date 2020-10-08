namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SubdivisionPlattedLegal
    {
        public int SearchId { get; set; }

        public int PlatReferenceId { get; set; }

        public int SubdivisionLevelId { get; set; }

        public virtual PlattedLegal PlattedLegal { get; set; }

        public virtual Search Search { get; set; }
    }
}