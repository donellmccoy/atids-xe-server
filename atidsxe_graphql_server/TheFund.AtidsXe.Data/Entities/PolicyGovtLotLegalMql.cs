namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyGovtLotLegalMql
    {
        public int PolicyId { get; set; }

        public int GovernmentLotId { get; set; }

        public int UnplattedReferenceId { get; set; }

        public virtual GovernmentLotLegal GovernmentLotLegal { get; set; }

        public virtual Policy Policy { get; set; }
    }
}