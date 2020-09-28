using System.Collections.Generic;
using HotChocolate.Types;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventStatusAssignor
    {
        public TitleEventStatusAssignor()
        {
            TitleEvent = new HashSet<TitleEvent>();
        }

        public int TitleEventStatusAssignorId { get; set; }

        public string Description { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<TitleEvent> TitleEvent { get; set; }
    }
}