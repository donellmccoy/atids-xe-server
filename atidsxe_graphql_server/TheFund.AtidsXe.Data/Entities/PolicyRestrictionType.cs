using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyRestrictionType
    {
        public PolicyRestrictionType()
        {
            Policies = new HashSet<Policy>();
        }

        public int PolicyRestrictionTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<Policy> Policies { get; set; }
    }
}