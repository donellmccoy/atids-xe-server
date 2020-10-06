namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventParty
    {
        public int TitleEventId { get; set; }
        public int PartyId { get; set; }

        public virtual Party Party { get; set; }
        public virtual TitleEvent TitleEvent { get; set; }
    }
}