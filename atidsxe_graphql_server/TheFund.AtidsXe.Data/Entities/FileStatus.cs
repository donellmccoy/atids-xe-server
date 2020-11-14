using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class FileStatus
    {
        public FileStatus()
        {
            FileReferences = new HashSet<FileReference>();
        }

        public int FileStatusId { get; set; }

        [Trim]
        public string Description { get; set; }

        public ICollection<FileReference> FileReferences { get; set; }
    }
}