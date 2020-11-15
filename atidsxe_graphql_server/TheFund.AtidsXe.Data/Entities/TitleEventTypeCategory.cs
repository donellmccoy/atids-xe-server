using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventTypeCategory
    {
        public TitleEventTypeCategory()
        {
            TitleEventTypes = new HashSet<TitleEventType>();
        }

        public int TitleEventCategoryId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<TitleEventType> TitleEventTypes { get; set; }
    }
}