using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SearchWarningType
    {
        public SearchWarningType()
        {
            SearchWarning = new HashSet<SearchWarning>();
        }

        public int SearchWarningTypeId { get; set; }
        public string Description { get; set; }

        public virtual SearchWarningHelp SearchWarningHelp { get; set; }

        public virtual ICollection<SearchWarning> SearchWarning { get; set; }
    }
}