using System.Collections.Generic;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ChainOfTitle
    {
        public ChainOfTitle()
        {
            ChainOfTitleItems = new HashSet<ChainOfTitleItem>();
            //ChainOfTitleNotes = new HashSet<ChainOfTitleNotes>();
            //ChainOfTitleSearch = new HashSet<ChainOfTitleSearch>();
        }

        public int ChainOfTitleId { get; set; }

        public int FileReferenceId { get; set; }

        public FileReference FileReference { get; set; }

        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public ICollection<ChainOfTitleItem> ChainOfTitleItems { get; set; }

        //public virtual ICollection<ChainOfTitleNotes> ChainOfTitleNotes { get; set; }
        //public virtual ICollection<ChainOfTitleSearch> ChainOfTitleSearch { get; set; }
    }
}