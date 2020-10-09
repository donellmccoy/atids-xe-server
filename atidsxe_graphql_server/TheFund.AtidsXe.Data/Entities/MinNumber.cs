using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class MinNumber
    {
        public MinNumber()
        {
            MortgageTitleEvent = new HashSet<MortgageTitleEvent>();
        }

        public int MinNumberId { get; set; }

        [Trim]
        public string MinLender { get; set; }

        [Trim]
        public string MinSerial { get; set; }

        [Trim]
        public string MinCheckDigit { get; set; }

        public virtual ICollection<MortgageTitleEvent> MortgageTitleEvent { get; set; }
    }
}