using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class NameSearchStatusCode
    {
        public NameSearchStatusCode()
        {
            NameSearchListItems = new HashSet<NameSearchListItem>();
        }

        public int NameSearchStatusCodeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<NameSearchListItem> NameSearchListItems { get; set; }
    }
}