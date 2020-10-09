using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PropertyAddress
    {
        public int OfficialRecordDocumentId { get; set; }

        [Trim]
        public string AddressLine1 { get; set; }

        [Trim]
        public string AddressLine2 { get; set; }

        [Trim]
        public string City { get; set; }

        [Trim]
        public string State { get; set; }

        [Trim]
        public string PostalCode { get; set; }

        [Trim]
        public string Country { get; set; }

        [Trim]
        public string UnparsedAddress { get; set; }

        public virtual OfficialRecordDocument OfficialRecordDocument { get; set; }
    }
}