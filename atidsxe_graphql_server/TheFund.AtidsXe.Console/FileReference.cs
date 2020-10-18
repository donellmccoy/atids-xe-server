using System;

namespace TheFund.AtidsXe.Console
{
    public class FileReference
    {
        public string __Typename { get; set; }

        public int FileReferenceId { get; set; }

        public string Name { get; set; }

        public int DefaultGeographicLocaleId { get; set; }

        public int BranchLocationId { get; set; }

        public int FileStatusId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public string WorkerId { get; set; }

        public byte? IsTemporaryFile { get; set; }

        public TitleSearchOrigination titleSearchOrigination { get; set; }

        public ChainOfTitlesConnection ChainOfTitlesConnection { get; set; }

        public FileReferenceNotesConnection FileReferenceNotesConnection { get; set; }

        public Worksheet Worksheet { get; set; }

        public SearchesConnection SearchesConnection { get; set; }
    }
}
