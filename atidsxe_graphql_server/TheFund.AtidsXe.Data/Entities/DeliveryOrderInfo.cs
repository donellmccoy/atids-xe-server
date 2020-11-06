using System;
using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class DeliveryOrderInfo
    {
        public DeliveryOrderInfo()
        {
            PolicyOrderTracking = new HashSet<PolicyOrderTracking>();
            TitleEventOrderTracking = new HashSet<TitleEventOrderTracking>();
        }

        public int DeliveryOrderInfoId { get; set; }

        public int? PageCount { get; set; }

        public byte ImagedFlag { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime CreateDate { get; set; }

        [Trim]
        public string Email { get; set; }

        public virtual ICollection<PolicyOrderTracking> PolicyOrderTracking { get; set; }

        public virtual ICollection<TitleEventOrderTracking> TitleEventOrderTracking { get; set; }
    }
}