using System.Collections.Generic;

namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public sealed class FileReferencesResponse
    {
        public Connection<FileReference> FileReferencesConnection { get; set; }

        public IEnumerable<FileReference> FileReferences => FileReferencesConnection?.Nodes ?? new List<FileReference>();

        public PageInfo PageInfo => FileReferencesConnection?.PageInfo ?? new PageInfo();

        public int TotalCount => FileReferencesConnection?.TotalCount ??  0;
    }
}
