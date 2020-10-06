using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PlatReference
    {
        public PlatReference()
        {
            PlattedLegal = new HashSet<PlattedLegal>();
        }

        public int PlatReferenceId { get; set; }
        public string Source { get; set; }
        public string Book { get; set; }
        public string BookSuffix { get; set; }
        public string Page { get; set; }
        public string PageSuffix { get; set; }

        public virtual PlatProperties PlatProperties { get; set; }
        public virtual ICollection<PlattedLegal> PlattedLegal { get; set; }
    }
}