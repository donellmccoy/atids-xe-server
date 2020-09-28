namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ChainOfTitleSearch
    {
        public int ChainOfTitleId { get; set; }

        public int SearchId { get; set; }

        public virtual ChainOfTitle ChainOfTitle { get; set; }

        public virtual Search Search { get; set; }
    }
}