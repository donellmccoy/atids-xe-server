using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SearchWarningType
    {
        public SearchWarningType()
        {
            SearchWarnings = new HashSet<SearchWarning>();
        }

        public int SearchWarningTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual SearchWarningHelp SearchWarningHelp { get; set; }

        public virtual ICollection<SearchWarning> SearchWarnings { get; set; }
    }
}