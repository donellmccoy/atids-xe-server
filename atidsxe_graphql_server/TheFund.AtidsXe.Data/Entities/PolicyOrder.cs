using System;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyOrder
    {
        public PolicyOrder()
        {
            PolicyOrderTracking = new HashSet<PolicyOrderTracking>();
        }

        public int PolicyOrderId { get; set; }
        public string TrackingIdentifier { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<PolicyOrderTracking> PolicyOrderTracking { get; set; }
    }
}