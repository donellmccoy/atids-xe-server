using System.Collections.Generic;

namespace TheFund.AtidsXe.Console
{
    public class FileReferenceConnection
    {
        public FileReferenceConnection()
        {
            FileReferences = new List<FileReference>();
        }

        public int TotalCount { get; set; }

        public PageInfo PageInfo { get; set; }

        public List<FileReference> FileReferences { get; set; }
    }
}
