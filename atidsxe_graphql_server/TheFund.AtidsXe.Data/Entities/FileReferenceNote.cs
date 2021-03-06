﻿using System;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class FileReferenceNote
    {
        public int FileReferenceNotesId { get; set; }

        public int FileReferenceId { get; set; }

        [Trim]
        public string UserId { get; set; }

        public DateTime TimeStamp { get; set; }

        [Trim]
        public string Message { get; set; }

        public FileReference FileReference { get; set; }
    }
}