namespace TheFund.AtidsXe.Data.Entities
{
    public partial class FileStatus
    {
        public FileStatus()
        {
            //FileReference = new HashSet<FileReference>();
        }

        public int FileStatusId { get; set; }
        public string Description { get; set; }

        //[InverseProperty("FileStatus")]
        //public virtual ICollection<FileReference> FileReference { get; set; }
    }
}