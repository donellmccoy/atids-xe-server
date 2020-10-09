using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TypeOfInstrument
    {
        public TypeOfInstrument()
        {
            OrDocumentInformation = new HashSet<OrDocumentInformation>();
        }

        public int TypeOfInstrumentId { get; set; }

        [Trim]
        public string TypeOfInstrument1 { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<OrDocumentInformation> OrDocumentInformation { get; set; }
    }
}