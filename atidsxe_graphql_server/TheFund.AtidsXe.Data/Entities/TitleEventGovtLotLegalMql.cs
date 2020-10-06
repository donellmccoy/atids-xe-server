namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventGovtLotLegalMql
    {
        public int UnplattedReferenceId { get; set; }
        public int GovernmentLotId { get; set; }
        public int TitleEventId { get; set; }

        public virtual GovernmentLotLegal GovernmentLotLegal { get; set; }
        public virtual TitleEvent TitleEvent { get; set; }
    }
}