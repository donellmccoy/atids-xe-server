using System.Collections.Generic;
using TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects;

namespace TheFund.AtidsXe.Blazor.Server.Models.Responses
{
    public sealed class FileReferencesResponse
    {
        public Connection<FileReferenceDTO> FileReferencesConnection { get; set; }

        public IEnumerable<FileReferenceDTO> FileReferences => FileReferencesConnection?.Nodes ?? new List<FileReferenceDTO>();

        public PageInfoDTO PageInfo => FileReferencesConnection?.PageInfo ?? new PageInfoDTO();

        public int TotalCount => FileReferencesConnection?.TotalCount ??  0;
    }
}
