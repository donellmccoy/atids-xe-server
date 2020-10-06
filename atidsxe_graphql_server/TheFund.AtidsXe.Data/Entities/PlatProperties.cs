using System;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PlatProperties
    {
        public int PlatReferenceId { get; set; }
        public DateTime? CertificationDate { get; set; }
        public string PlatName { get; set; }
        public DateTime? PlatDate { get; set; }
        public byte? PostingsConform { get; set; }
        public byte? IntervalOwnership { get; set; }
        public byte? RetroCertified { get; set; }
        public string PrimaryHierarchy { get; set; }
        public string AlternateHierarchy1 { get; set; }
        public string AlternateHierarchy2 { get; set; }

        public virtual PlatReference PlatReference { get; set; }
    }
}