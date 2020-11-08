using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ChainOfTitleCategory
    {
        public ChainOfTitleCategory()
        {
            ChainOfTitleItems = new HashSet<ChainOfTitleItem>();
        }

        public int ChainOfTitleCategoryId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<ChainOfTitleItem> ChainOfTitleItems { get; set; }
    }
}