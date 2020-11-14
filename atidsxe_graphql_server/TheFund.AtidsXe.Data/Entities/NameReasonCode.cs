using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class NameReasonCode
    {
        public NameReasonCode()
        {
            NameSearchListReasonCodes = new HashSet<NameSearchListReasonCode>();
        }

        public int NameReasonCodeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<NameSearchListReasonCode> NameSearchListReasonCodes { get; set; }
    }
}