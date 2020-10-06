using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SectionBreakdownCode
    {
        public SectionBreakdownCode()
        {
            SectionLegal = new HashSet<SectionLegal>();
        }

        public int SectionBreakdownCodeId { get; set; }
        public int SectionQuarter { get; set; }
        public int? Section16th { get; set; }
        public int? Section64th { get; set; }
        public int? Section256th { get; set; }

        public virtual ICollection<SectionLegal> SectionLegal { get; set; }
    }
}