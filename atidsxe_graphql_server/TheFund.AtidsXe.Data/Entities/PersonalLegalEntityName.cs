namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PersonalLegalEntityName
    {
        public int LegalEntityNameId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Lineage { get; set; }

        public string Prefix { get; set; }

        public string Suffix { get; set; }

        public virtual LegalEntityName LegalEntityName { get; set; }
    }
}