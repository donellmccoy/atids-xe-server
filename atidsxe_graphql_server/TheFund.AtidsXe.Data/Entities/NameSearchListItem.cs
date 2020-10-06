using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class NameSearchListItem
    {
        public NameSearchListItem()
        {
            NameSearchListReasonCode = new HashSet<NameSearchListReasonCode>();
        }

        public int NameSearchListItemId { get; set; }
        public int LegalEntityNameId { get; set; }
        public int ChainOfTitleId { get; set; }
        public int NameSearchStatusCodeId { get; set; }
        public int ReferenceTitleEventId { get; set; }

        public virtual LegalEntityName LegalEntityName { get; set; }
        public virtual NameSearchStatusCode NameSearchStatusCode { get; set; }
        public virtual TitleEvent ReferenceTitleEvent { get; set; }
        public virtual ICollection<NameSearchListReasonCode> NameSearchListReasonCode { get; set; }
    }
}