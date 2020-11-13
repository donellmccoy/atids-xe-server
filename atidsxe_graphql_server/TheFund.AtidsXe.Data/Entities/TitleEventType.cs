using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventType
    {
        public TitleEventType()
        {
            TitleEvent = new HashSet<TitleEvent>();
        }

        public int TitleEventTypeId { get; set; }

        [Trim]
        public string TitleEventCode { get; set; }

        [Trim]
        public string Description { get; set; }

        public int EventCategoryId { get; set; }

        public virtual TitleEventTypeCategory EventCategory { get; set; }

        public virtual ICollection<TitleEvent> TitleEvent { get; set; }
    }
}