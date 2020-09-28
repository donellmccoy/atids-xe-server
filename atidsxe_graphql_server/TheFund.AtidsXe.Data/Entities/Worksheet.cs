using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class Worksheet
    {
        public Worksheet()
        {
            WorksheetItems = new HashSet<WorksheetItem>();
        }

        public int WorksheetId { get; set; }

        public int FileReferenceId { get; set; }

        public FileReference FileReference { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<WorksheetItem> WorksheetItems { get; set; }
    }
}