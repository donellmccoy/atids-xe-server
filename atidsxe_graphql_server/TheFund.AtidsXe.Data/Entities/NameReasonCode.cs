using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class NameReasonCode
    {
        public NameReasonCode()
        {
            NameSearchListReasonCode = new HashSet<NameSearchListReasonCode>();
        }

        public int NameReasonCodeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<NameSearchListReasonCode> NameSearchListReasonCode { get; set; }
    }
}