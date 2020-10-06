namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyOrderTracking
    {
        public int PolicyId { get; set; }
        public int PolicyOrderId { get; set; }
        public int DeliveryOrderInfoId { get; set; }

        public virtual DeliveryOrderInfo DeliveryOrderInfo { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual PolicyOrder PolicyOrder { get; set; }
    }
}