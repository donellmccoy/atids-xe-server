using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PlattedLegal
    {
        public PlattedLegal()
        {
            PolicyPlattedLegalMqls = new HashSet<PolicyPlattedLegalMql>();
            SubdivisionPlattedLegals = new HashSet<SubdivisionPlattedLegal>();
            TitleEventPlattedLegalMqls = new HashSet<TitleEventPlattedLegalMql>();
        }

        public int PlatReferenceId { get; set; }

        public int SubdivisionLevelId { get; set; }

        public virtual PlatReference PlatReference { get; set; }

        public virtual SubdivisionLevels SubdivisionLevel { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicyPlattedLegalMql> PolicyPlattedLegalMqls { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<SubdivisionPlattedLegal> SubdivisionPlattedLegals { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<TitleEventPlattedLegalMql> TitleEventPlattedLegalMqls { get; set; }
    }
}