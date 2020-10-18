using System;

namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public sealed class FileReferenceDTO : DtoBase
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

        public bool IsTemporaryFileBool => IsTemporaryFile == 1;

        public TitleSearchOriginationDTO titleSearchOrigination { get; set; }

        public Connection<ChainOfTitleDTO> ChainOfTitlesConnection { get; set; }

        public Connection<FileReferenceNoteDTO> FileReferenceNotesConnection { get; set; }

        public WorksheetDTO Worksheet { get; set; }

        public Connection<SearchDTO> SearchesConnection { get; set; }
    }
}
