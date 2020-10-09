using System;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class OrDocumentInformation
    {
        public int OfficialRecordDocumentId { get; set; }

        public DateTime? DateOfFiling { get; set; }

        public int TypeOfInstrumentId { get; set; }

        [Trim]
        public string ToiAdditionalInformation { get; set; }

        [Trim]
        public string UnparsedRelatedReference { get; set; }

        [Trim]
        public string UnparsedLegalDescription { get; set; }

        public decimal? Amount { get; set; }

        public int? PageCount { get; set; }

        public byte ImageAvailable { get; set; }

        [Trim]
        public string ScrivnerName { get; set; }

        [Trim]
        public string Comments { get; set; }

        public int? CriticalItemsHash { get; set; }

        public int? FullHash { get; set; }

        public DateTime? LastImageUpdate { get; set; }

        [Trim]
        public string Md5CriticalItemsHash { get; set; }

        public virtual OfficialRecordDocument OfficialRecordDocument { get; set; }

        public virtual TypeOfInstrument TypeOfInstrument { get; set; }
    }
}