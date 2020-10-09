using System;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PlatProperties
    {
        public int PlatReferenceId { get; set; }

        public DateTime? CertificationDate { get; set; }

        [Trim]
        public string PlatName { get; set; }

        public DateTime? PlatDate { get; set; }

        public byte? PostingsConform { get; set; }

        public byte? IntervalOwnership { get; set; }

        public byte? RetroCertified { get; set; }

        [Trim]
        public string PrimaryHierarchy { get; set; }

        [Trim]
        public string AlternateHierarchy1 { get; set; }

        [Trim]
        public string AlternateHierarchy2 { get; set; }

        public virtual PlatReference PlatReference { get; set; }
    }
}