namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ChainOfTitleItem
    {
        public int ChainOfTitleItemId { get; set; }

        public int ChainOfTitleId { get; set; }

        public int TitleEventId { get; set; }

        public int? ParentTitleEventId { get; set; }

        public int OrderIndex { get; set; }

        public byte UserModified { get; set; }

        public byte StartingTitleEvent { get; set; }

        public int ChainOfTitleCategoryId { get; set; }

        public ChainOfTitle ChainOfTitle { get; set; }

        public ChainOfTitleCategory ChainOfTitleCategory { get; set; }

        public TitleEvent TitleEvent { get; set; }
    }
}