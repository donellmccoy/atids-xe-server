using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ChainOfTitle
    {
        public ChainOfTitle()
        {
            ChainOfTitleItems = new HashSet<ChainOfTitleItem>();
            ChainOfTitleNotes = new HashSet<ChainOfTitleNotes>();
            ChainOfTitleSearches = new HashSet<ChainOfTitleSearch>();
        }

        public int ChainOfTitleId { get; set; }

        public int FileReferenceId { get; set; }

        public virtual FileReference FileReference { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<ChainOfTitleItem> ChainOfTitleItems { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<ChainOfTitleNotes> ChainOfTitleNotes { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<ChainOfTitleSearch> ChainOfTitleSearches { get; set; }
    }
}