namespace TheFund.AtidsXe.Data.Entities
{
    public partial class AcreageGovtLotLegal
    {
        public int SearchId { get; set; }
        public int GovernmentLotId { get; set; }
        public int UnplattedReferenceId { get; set; }

        public virtual GovernmentLotLegal GovernmentLotLegal { get; set; }
        public virtual Search Search { get; set; }
    }
}