﻿namespace TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects
{
    public sealed class PageInfo
    {
        public string StartCursor { get; set; }

        public string EndCursor { get; set; }

        public bool HasPreviousPage { get; set; }

        public bool HasNextPage { get; set; }
    }
}
