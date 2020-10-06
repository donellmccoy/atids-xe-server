namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyTitleStatusReport
    {
        public int SearchId { get; set; }
        public string TitleStatusReportCode { get; set; }
        public string TitleStatusReportNumber { get; set; }

        public virtual Search Search { get; set; }
    }
}