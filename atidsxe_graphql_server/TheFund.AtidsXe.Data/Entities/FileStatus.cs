using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class FileStatus
    {
        public FileStatus()
        {
            FileReference = new HashSet<FileReference>();
        }

        public int FileStatusId { get; set; }

        [Trim]
        public string Description { get; set; }

        public ICollection<FileReference> FileReference { get; set; }
    }
}