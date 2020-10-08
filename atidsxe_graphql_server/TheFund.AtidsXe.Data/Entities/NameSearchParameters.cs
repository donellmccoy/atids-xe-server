namespace TheFund.AtidsXe.Data.Entities
{
    public partial class NameSearchParameters
    {
        public int SearchId { get; set; }

        public int LegalEntityNameId { get; set; }

        public byte SearchGiNames { get; set; }

        public byte SearchGrantorNames { get; set; }

        public byte SearchGranteeNames { get; set; }

        public byte SearchNickNames { get; set; }

        public byte SearchSimilarSoundingNames { get; set; }

        public byte FlipNames { get; set; }

        public byte LastNamePctOfLikeness { get; set; }

        public byte FirstNamePctOfLikeness { get; set; }

        public int OwnerBuyerRelationshipId { get; set; }

        public string LegalFilter { get; set; }

        public virtual LegalEntityName LegalEntityName { get; set; }

        public virtual OwnerBuyerRelationship OwnerBuyerRelationship { get; set; }

        public virtual Search Search { get; set; }
    }
}