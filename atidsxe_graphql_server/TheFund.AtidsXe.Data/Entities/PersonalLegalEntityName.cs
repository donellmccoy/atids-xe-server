using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PersonalLegalEntityName
    {
        public int LegalEntityNameId { get; set; }

        [Trim]
        public string LastName { get; set; }

        [Trim]
        public string FirstName { get; set; }

        [Trim]
        public string MiddleName { get; set; }

        [Trim]
        public string Lineage { get; set; }

        [Trim]
        public string Prefix { get; set; }

        [Trim]
        public string Suffix { get; set; }

        public virtual LegalEntityName LegalEntityName { get; set; }
    }
}