using System;

namespace TheFund.AtidsXe.Console
{
    public sealed class FileReferencesRequest
    {
        public FileReferencesRequest(int fileReferenceId, PagingOptions pagingOptions)
        {
            FileReferenceId = fileReferenceId;
            PagingOptions = pagingOptions ?? throw new ArgumentNullException(nameof(pagingOptions));
        }

        public int Key => FileReferenceId;

        public int FileReferenceId { get; }

        public PagingOptions PagingOptions { get; }
    }
}
