namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PartyLegalEntityName
    {
        public int PartyId { get; set; }
        public int LegalEntityNameId { get; set; }

        public virtual LegalEntityName LegalEntityName { get; set; }
        public virtual Party Party { get; set; }
    }
}