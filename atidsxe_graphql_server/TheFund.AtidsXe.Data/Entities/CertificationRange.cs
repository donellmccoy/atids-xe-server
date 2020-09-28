using HotChocolate.Types;
using System;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class CertificationRange
    {
        public CertificationRange()
        {
            SearchGeographicCertRange = new HashSet<Search>();
            SearchGiCertRange = new HashSet<Search>();
            SearchGrantorCertRange = new HashSet<Search>();
        }

        public int CertificationRangeId { get; set; }

        public DateTime FromDate { get; set; }

        public int FromOrDocumentId { get; set; }

        public DateTime ToDate { get; set; }

        public int ToOrDocumentId { get; set; }

        //public virtual OfficialRecordDocument FromOrDocument { get; set; }

        //public virtual OfficialRecordDocument ToOrDocument { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<Search> SearchGeographicCertRange { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<Search> SearchGiCertRange { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<Search> SearchGrantorCertRange { get; set; }
    }
}