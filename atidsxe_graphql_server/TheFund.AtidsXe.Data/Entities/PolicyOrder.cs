﻿using System;
using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyOrder
    {
        public PolicyOrder()
        {
            PolicyOrderTrackings = new HashSet<PolicyOrderTracking>();
        }

        public int PolicyOrderId { get; set; }

        [Trim]
        public string TrackingIdentifier { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual ICollection<PolicyOrderTracking> PolicyOrderTrackings { get; set; }
    }
}