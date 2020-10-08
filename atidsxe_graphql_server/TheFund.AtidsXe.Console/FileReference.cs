using System;

namespace TheFund.AtidsXe.Console
{
    public class FileReference
    {
        public string Name { get; set; }

        public int FileReferenceId { get; set; }

        public int BranchLocationId { get; set; }

        public int FileStatusId { get; set; }

        public string WorkerId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public int? DefaultGeographicLocaleId { get; set; }

        public byte? IsTemporaryFile { get; set; }

        public TitleSearchOrigination TitleSearchOrigination { get; set; }


    }
}
