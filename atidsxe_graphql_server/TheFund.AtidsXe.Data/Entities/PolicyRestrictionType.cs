using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyRestrictionType
    {
        public PolicyRestrictionType()
        {
            Policy = new HashSet<Policy>();
        }

        public int PolicyRestrictionTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<Policy> Policy { get; set; }
    }
}