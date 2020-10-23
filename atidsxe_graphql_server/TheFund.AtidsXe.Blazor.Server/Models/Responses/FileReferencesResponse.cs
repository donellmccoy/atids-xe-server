using System.Collections.Generic;
using TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects;

namespace TheFund.AtidsXe.Blazor.Server.Models.Responses
{
    public sealed class FileReferencesResponse
    {
        public Connection<FileReference> FileReferencesConnection { get; set; }

        public IEnumerable<FileReference> FileReferences => FileReferencesConnection?.Nodes ?? new List<FileReference>();

        public PageInfo PageInfo => FileReferencesConnection?.PageInfo ?? new PageInfo();

        public int TotalCount => FileReferencesConnection?.TotalCount ??  0;
    }
}
