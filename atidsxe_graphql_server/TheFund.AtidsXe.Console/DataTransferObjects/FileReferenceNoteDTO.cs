using System;

namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public sealed class FileReferenceNoteDTO : DtoBase
    {
        public int FileReferenceId { get; set; }

        public int FileReferenceNotesId { get; set; }

        public string Message { get; set; }

        public string UserId { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
