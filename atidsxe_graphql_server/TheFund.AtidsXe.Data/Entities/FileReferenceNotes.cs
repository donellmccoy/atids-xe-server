﻿using System;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class FileReferenceNotes
    {
        public int FileReferenceNotesId { get; set; }

        public int FileReferenceId { get; set; }

        public string UserId { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Message { get; set; }

        public FileReference FileReference { get; set; }
    }
}