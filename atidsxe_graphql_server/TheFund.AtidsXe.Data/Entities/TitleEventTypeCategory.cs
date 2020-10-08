using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventTypeCategory
    {
        public TitleEventTypeCategory()
        {
            TitleEventType = new HashSet<TitleEventType>();
        }

        public int TitleEventCategoryId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<TitleEventType> TitleEventType { get; set; }
    }
}