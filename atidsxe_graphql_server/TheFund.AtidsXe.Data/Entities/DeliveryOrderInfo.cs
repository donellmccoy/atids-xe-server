using System;
using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class DeliveryOrderInfo
    {
        public DeliveryOrderInfo()
        {
            PolicyOrderTrackings = new HashSet<PolicyOrderTracking>();
            TitleEventOrderTrackings = new HashSet<TitleEventOrderTracking>();
        }

        public int DeliveryOrderInfoId { get; set; }

        public int? PageCount { get; set; }

        public byte ImagedFlag { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime CreateDate { get; set; }

        [Trim]
        public string Email { get; set; }

        public virtual ICollection<PolicyOrderTracking> PolicyOrderTrackings { get; set; }

        public virtual ICollection<TitleEventOrderTracking> TitleEventOrderTrackings { get; set; }
    }
}