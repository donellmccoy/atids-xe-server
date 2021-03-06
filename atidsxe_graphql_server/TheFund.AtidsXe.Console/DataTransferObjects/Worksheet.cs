﻿namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public sealed class Worksheet : DtoBase
    {
        public int WorksheetId { get; set; }

        public int FileReferenceId { get; set; }

        public Connection<WorksheetItem> WorksheetItemsConnection { get; set; }
    }
}
