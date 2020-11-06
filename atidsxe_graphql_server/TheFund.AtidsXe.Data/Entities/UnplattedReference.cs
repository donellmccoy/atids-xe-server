using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class UnplattedReference
    {
        public UnplattedReference()
        {
            GovernmentLotLegal = new HashSet<GovernmentLotLegal>();
            SectionLegal = new HashSet<SectionLegal>();
        }

        public int UnplattedReferenceId { get; set; }

        [Trim]
        public string Meridian { get; set; }

        [Trim]
        public string Range { get; set; }

        public int RangeDirectionTypeId { get; set; }

        [Trim]
        public string Township { get; set; }

        public int TownshipDirectionTypeId { get; set; }

        [Trim]
        public string Section { get; set; }

        public int BreakdownCodeTypeId { get; set; }

        public virtual BreakdownCodeType BreakdownCodeType { get; set; }

        public virtual RangeDirectionType RangeDirectionType { get; set; }

        public virtual TownshipDirectionType TownshipDirectionType { get; set; }

        public virtual ICollection<GovernmentLotLegal> GovernmentLotLegal { get; set; }

        public virtual ICollection<SectionLegal> SectionLegal { get; set; }
    }
}