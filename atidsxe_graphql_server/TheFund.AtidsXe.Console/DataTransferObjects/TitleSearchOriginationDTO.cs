using System;

namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public class TitleSearchOriginationDTO
    {
        public int TitleSearchOriginationId { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderReference { get; set; }

        public int TitleEventId { get; set; }

        public int FileReferenceId { get; set; }
    }
}
