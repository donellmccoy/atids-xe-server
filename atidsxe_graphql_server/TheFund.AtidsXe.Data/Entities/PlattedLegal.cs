using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PlattedLegal
    {
        public PlattedLegal()
        {
            PolicyPlattedLegalMql = new HashSet<PolicyPlattedLegalMql>();
            SubdivisionPlattedLegal = new HashSet<SubdivisionPlattedLegal>();
            TitleEventPlattedLegalMql = new HashSet<TitleEventPlattedLegalMql>();
        }

        public int PlatReferenceId { get; set; }

        public int SubdivisionLevelId { get; set; }

        public virtual PlatReference PlatReference { get; set; }

        public virtual SubdivisionLevels SubdivisionLevel { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicyPlattedLegalMql> PolicyPlattedLegalMql { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<SubdivisionPlattedLegal> SubdivisionPlattedLegal { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<TitleEventPlattedLegalMql> TitleEventPlattedLegalMql { get; set; }
    }
}