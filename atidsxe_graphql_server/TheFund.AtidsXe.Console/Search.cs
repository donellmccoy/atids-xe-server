using System;

namespace TheFund.AtidsXe.Console
{
    public class Search
    {
        public string __Typename { get; set; }
        public int SearchId { get; set; }
        public int FileReferenceId { get; set; }
        public int SearchTypeId { get; set; }
        public DateTime SearchThruDate { get; set; }
        public DateTime SearchFromDate { get; set; }
        public int SearchStatusId { get; set; }
        public int GeographicLocaleId { get; set; }
        public int? GeographicCertRangeId { get; set; }
        public int? ParentSearchId { get; set; }
        public string InstrumentFilters { get; set; }
        public string LrsSearch { get; set; }
        public byte? InclMortgageeShortForm { get; set; }
        public byte? Hidden { get; set; }
    }


}
