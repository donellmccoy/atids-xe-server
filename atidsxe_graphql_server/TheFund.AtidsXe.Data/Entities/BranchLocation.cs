using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class BranchLocation
    {
        public BranchLocation()
        {
            FileReference = new HashSet<FileReference>();
        }

        public int BranchLocationId { get; set; }

        [Trim]
        public string Description { get; set; }

        [Trim]
        public string AccountNumber { get; set; }

        public byte? IsInternal { get; set; }

        public ICollection<FileReference> FileReference { get; set; }
    }
}