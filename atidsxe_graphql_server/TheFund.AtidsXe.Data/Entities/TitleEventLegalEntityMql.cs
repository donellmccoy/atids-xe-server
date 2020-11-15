namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventLegalEntityMql
    {
        public int TitleEventId { get; set; }

        public int LegalEntityNameId { get; set; }

        public virtual LegalEntityName LegalEntityName { get; set; }

        public virtual TitleEvent TitleEvent { get; set; }
    }
}