using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class MortgageTitleEvent
    {
        public int TitleEventId { get; set; }

        [Trim]
        public string LenderName { get; set; }

        public int MinNumberId { get; set; }

        public virtual MinNumber MinNumber { get; set; }

        public virtual TitleEvent TitleEvent { get; set; }
    }
}