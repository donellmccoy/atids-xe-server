using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class NameSearchStatusCode
    {
        public NameSearchStatusCode()
        {
            NameSearchListItem = new HashSet<NameSearchListItem>();
        }

        public int NameSearchStatusCodeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<NameSearchListItem> NameSearchListItem { get; set; }
    }
}