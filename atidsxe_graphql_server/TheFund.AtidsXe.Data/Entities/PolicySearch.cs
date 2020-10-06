namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicySearch
    {
        public int PolicyId { get; set; }
        public int SearchId { get; set; }

        public virtual Policy Policy { get; set; }
        public virtual Search Search { get; set; }
    }
}