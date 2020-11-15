using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class MinNumber
    {
        public MinNumber()
        {
            MortgageTitleEvents = new HashSet<MortgageTitleEvent>();
        }

        public int MinNumberId { get; set; }

        [Trim]
        public string MinLender { get; set; }

        [Trim]
        public string MinSerial { get; set; }

        [Trim]
        public string MinCheckDigit { get; set; }

        public virtual ICollection<MortgageTitleEvent> MortgageTitleEvents { get; set; }
    }
}