using System;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SearchWarning
    {
        public int SearchWarningId { get; set; }

        public int SearchId { get; set; }

        public int SearchWarningTypeId { get; set; }

        public string UnparsedSearchWarning { get; set; }

        public DateTime? CreateDate { get; set; }

        public virtual Search Search { get; set; }

        public virtual SearchWarningType SearchWarningType { get; set; }
    }
}