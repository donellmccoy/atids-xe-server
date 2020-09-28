using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SearchStatus
    {
        public SearchStatus()
        {
            Search = new HashSet<Search>();
        }

        public int SearchStatusId { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Search> Search { get; set; }
    }
}