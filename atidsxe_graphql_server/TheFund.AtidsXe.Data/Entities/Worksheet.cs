using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class Worksheet
    {
        public Worksheet()
        {
            WorksheetItem = new HashSet<WorksheetItem>();
        }

        public int WorksheetId { get; set; }

        public int FileReferenceId { get; set; }

        public FileReference FileReference { get; set; }

        public ICollection<WorksheetItem> WorksheetItem { get; set; }
    }
}