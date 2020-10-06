using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyRestrictionType
    {
        public PolicyRestrictionType()
        {
            Policy = new HashSet<Policy>();
        }

        public int PolicyRestrictionTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Policy> Policy { get; set; }
    }
}