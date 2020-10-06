namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyInsuredDocument
    {
        public int PolicyId { get; set; }
        public int GeographicLocaleId { get; set; }
        public string UnparsedInsuredDocument { get; set; }

        public virtual GeographicLocale GeographicLocale { get; set; }
        public virtual Policy Policy { get; set; }
    }
}