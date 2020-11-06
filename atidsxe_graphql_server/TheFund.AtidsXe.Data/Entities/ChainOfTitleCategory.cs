using HotChocolate.Types;
using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ChainOfTitleCategory
    {
        public ChainOfTitleCategory()
        {
            ChainOfTitleItem = new HashSet<ChainOfTitleItem>();
        }

        public int ChainOfTitleCategoryId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<ChainOfTitleItem> ChainOfTitleItem { get; set; }
    }
}