using System.Collections.Generic;
using TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects;

namespace TheFund.AtidsXe.Blazor.Server.Models.Responses
{
    public sealed class FileReferencesResponse
    {
        public Connection<FileReferenceDTO> FileReferencesConnection { get; set; }

        public IEnumerable<FileReferenceDTO> FileReferences => FileReferencesConnection?.Nodes ?? new List<FileReferenceDTO>();

        public PageInfo PageInfo => FileReferencesConnection?.PageInfo ?? new PageInfo();

        public int TotalCount => FileReferencesConnection?.TotalCount ??  0;
    }
}
