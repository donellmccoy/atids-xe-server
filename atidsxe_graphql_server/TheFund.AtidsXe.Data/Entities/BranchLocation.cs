using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

        [InverseProperty("BranchLocation")]
        public virtual ICollection<FileReference> FileReference { get; set; }
    }
}