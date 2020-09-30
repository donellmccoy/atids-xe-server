using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class FileReference
    {
        public FileReference()
        {
            ChainOfTitles = new HashSet<ChainOfTitle>();
            FileReferenceNotes = new HashSet<FileReferenceNotes>();
            Searches = new HashSet<Search>();
        }

        public int FileReferenceId { get; set; }

        public int BranchLocationId { get; set; }

        public string Name { get; set; }

        public int FileStatusId { get; set; }

        public string WorkerId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public int? DefaultGeographicLocaleId { get; set; }

        public byte? IsTemporaryFile { get; set; }

        public virtual BranchLocation BranchLocation { get; set; }

        public virtual GeographicLocale DefaultGeographicLocale { get; set; }

        public virtual FileStatus FileStatus { get; set; }

        public virtual TitleSearchOrigination TitleSearchOrigination { get; set; }

        public virtual Worksheet Worksheet { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<FileReferenceNotes> FileReferenceNotes { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<ChainOfTitle> ChainOfTitles { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<Search> Searches { get; set; }
    }
}