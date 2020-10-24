using System;

namespace TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects
{
    public sealed class FileReferenceNoteDTO : BaseDTO
    {
        public int FileReferenceId { get; set; }

        public int FileReferenceNotesId { get; set; }

        public string Message { get; set; }

        public string UserId { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
