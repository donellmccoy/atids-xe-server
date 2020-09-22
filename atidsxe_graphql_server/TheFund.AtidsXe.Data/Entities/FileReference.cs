using System;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class FileReference
    {
        public FileReference()
        {
        }

        public int FileReferenceId { get; set; }

        public int BranchLocationId { get; set; }

        public string FileReference1 { get; set; }

        public int FileStatusId { get; set; }

        public string WorkerId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public int? DefaultGeographicLocaleId { get; set; }

        public byte? IsTemporaryFile { get; set; }

        public virtual BranchLocation BranchLocation { get; set; }

        public virtual GeographicLocale DefaultGeographicLocale { get; set; }

        public virtual FileStatus FileStatus { get; set; }
    }
}