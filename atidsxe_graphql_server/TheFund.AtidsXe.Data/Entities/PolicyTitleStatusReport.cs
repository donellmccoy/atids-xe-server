using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyTitleStatusReport
    {
        public int SearchId { get; set; }

        [Trim]
        public string TitleStatusReportCode { get; set; }

        [Trim]
        public string TitleStatusReportNumber { get; set; }

        public virtual Search Search { get; set; }
    }
}