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

        public BranchLocation BranchLocation { get; set; }

        public GeographicLocale DefaultGeographicLocale { get; set; }

        public FileStatus FileStatus { get; set; }

        public TitleSearchOrigination TitleSearchOrigination { get; set; }

        public Worksheet Worksheet { get; set; }

        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public ICollection<FileReferenceNotes> FileReferenceNotes { get; set; }

        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public ICollection<ChainOfTitle> ChainOfTitles { get; set; }

        //public ICollection<Search> Search { get; set; }
    }
}