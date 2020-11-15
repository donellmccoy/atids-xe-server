namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventOrderTracking
    {
        public int TitleEventId { get; set; }

        public int TitleEventOrderId { get; set; }

        public int DeliveryOrderInfoId { get; set; }

        public virtual DeliveryOrderInfo DeliveryOrderInfo { get; set; }

        public virtual TitleEvent TitleEvent { get; set; }

        public virtual TitleEventOrder TitleEventOrder { get; set; }
    }
}