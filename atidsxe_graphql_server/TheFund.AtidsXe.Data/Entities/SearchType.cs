using HotChocolate.Types;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SearchType
    {
        public SearchType()
        {
            Searches = new HashSet<Search>();
        }

        public int SearchTypeId { get; set; }

        public string Description { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<Search> Searches { get; set; }
    }
}