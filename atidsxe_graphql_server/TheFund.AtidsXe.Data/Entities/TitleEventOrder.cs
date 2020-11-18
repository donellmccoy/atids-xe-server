using System;
using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventOrder
    {
        public TitleEventOrder()
        {
            TitleEventOrderTrackings = new HashSet<TitleEventOrderTracking>();
        }

        public int TitleEventOrderId { get; set; }

        [Trim]
        public string TrackingIdentifier { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual ICollection<TitleEventOrderTracking> TitleEventOrderTrackings { get; set; }
    }
}