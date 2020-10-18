using System;

namespace TheFund.AtidsXe.Console
{
    public class FileReferenceNote
    {
        public string __Typename { get; set; }
        public int FileReferenceId { get; set; }
        public int FileReferenceNotesId { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
        public DateTime TimeStamp { get; set; }
    }


}
