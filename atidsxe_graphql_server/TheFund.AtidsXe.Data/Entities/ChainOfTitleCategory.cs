using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ChainOfTitleCategory
    {
        public ChainOfTitleCategory()
        {
            ChainOfTitleItem = new HashSet<ChainOfTitleItem>();
        }

        public int ChainOfTitleCategoryId { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ChainOfTitleItem> ChainOfTitleItem { get; set; }
    }
}