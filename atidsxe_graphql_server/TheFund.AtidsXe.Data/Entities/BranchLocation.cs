using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class BranchLocation
    {
        public BranchLocation()
        {
            FileReference = new HashSet<FileReference>();
        }

        public int BranchLocationId { get; set; }

        public string Description { get; set; }

        public string AccountNumber { get; set; }

        public byte? IsInternal { get; set; }

        public ICollection<FileReference> FileReference { get; set; }
    }
}