using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SearchWarningType
    {
        public SearchWarningType()
        {
            SearchWarning = new HashSet<SearchWarning>();
        }

        public int SearchWarningTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual SearchWarningHelp SearchWarningHelp { get; set; }

        public virtual ICollection<SearchWarning> SearchWarning { get; set; }
    }
}