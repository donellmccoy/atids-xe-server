using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class FileStatus
    {
        public FileStatus()
        {
            FileReference = new HashSet<FileReference>();
        }

        public int FileStatusId { get; set; }

        public string Description { get; set; }

        public ICollection<FileReference> FileReference { get; set; }
    }
}