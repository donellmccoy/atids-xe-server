using System.Collections.Generic;
using HotChocolate.Types;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventStatusAssignor
    {
        public TitleEventStatusAssignor()
        {
            TitleEvents = new HashSet<TitleEvent>();
        }

        public int TitleEventStatusAssignorId { get; set; }

        [Trim]
        public string Description { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<TitleEvent> TitleEvents { get; set; }
    }
}