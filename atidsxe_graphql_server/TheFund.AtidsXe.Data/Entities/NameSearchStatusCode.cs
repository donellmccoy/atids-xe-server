using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class NameSearchStatusCode
    {
        public NameSearchStatusCode()
        {
            NameSearchListItem = new HashSet<NameSearchListItem>();
        }

        public int NameSearchStatusCodeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<NameSearchListItem> NameSearchListItem { get; set; }
    }
}