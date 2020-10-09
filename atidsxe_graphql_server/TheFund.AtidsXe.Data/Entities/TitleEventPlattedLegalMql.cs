namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventPlattedLegalMql
    {
        public int SubdivisionLevelId { get; set; }

        public int PlatReferenceId { get; set; }

        public int TitleEventId { get; set; }

        public virtual PlattedLegal PlattedLegal { get; set; }

        public virtual TitleEvent TitleEvent { get; set; }
    }
}