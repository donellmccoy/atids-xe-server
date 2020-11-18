using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SearchStatus
    {
        public SearchStatus()
        {
            Searches = new HashSet<Search>();
        }

        public int SearchStatusId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<Search> Searches { get; set; }
    }
}