using System;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleSearchOrigination
    {
        public int TitleSearchOriginationId { get; set; }

        public DateTime OrderDate { get; set; }

        [Trim]
        public string OrderReference { get; set; }

        public int TitleEventId { get; set; }

        public int FileReferenceId { get; set; }

        public FileReference FileReference { get; set; }

        public TitleEvent TitleEvent { get; set; }
    }
}