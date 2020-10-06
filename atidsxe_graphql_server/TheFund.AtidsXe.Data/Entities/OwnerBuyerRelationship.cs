using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class OwnerBuyerRelationship
    {
        public OwnerBuyerRelationship()
        {
            NameSearchParameters = new HashSet<NameSearchParameters>();
        }

        public int OwnerBuyerRelationshipId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<NameSearchParameters> NameSearchParameters { get; set; }
    }
}