using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SearchWarningHelp
    {
        public int SearchWarningTypeId { get; set; }

        [Trim]
        public string HelpText { get; set; }

        public virtual SearchWarningType SearchWarningType { get; set; }
    }
}