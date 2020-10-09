namespace TheFund.AtidsXe.Data.Entities
{
    public partial class NameSearchListReasonCode
    {
        public int NameSearchListItemId { get; set; }

        public int NameReasonCodeId { get; set; }

        public virtual NameReasonCode NameReasonCode { get; set; }

        public virtual NameSearchListItem NameSearchListItem { get; set; }
    }
}