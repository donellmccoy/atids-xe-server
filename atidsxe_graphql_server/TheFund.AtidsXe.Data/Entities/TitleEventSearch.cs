namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventSearch
    {
        public int TitleEventId { get; set; }
        public int SearchId { get; set; }

        public virtual Search Search { get; set; }
        public virtual TitleEvent TitleEvent { get; set; }
    }
}