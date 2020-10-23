using System;

namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public sealed class FileReference
    {
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

        public Worksheet Worksheet { get; set; }

        public Connection<ChainOfTitle> ChainOfTitlesConnection { get; set; }

        public Connection<FileReferenceNote> FileReferenceNotesConnection { get; set; }

        public Connection<Search> SearchesConnection { get; set; }
    }
}
