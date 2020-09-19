namespace TheFund.AtidsXe.Data.Entities
{
    public partial class BranchLocation
    {
        public BranchLocation()
        {
        }

        public int BranchLocationId { get; set; }

        public string Description { get; set; }

        public string AccountNumber { get; set; }

        public byte? IsInternal { get; set; }

        //[InverseProperty("BranchLocation")]
        //public virtual ICollection<FileReference> FileReference { get; set; }
    }
}