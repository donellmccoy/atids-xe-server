using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ExaminationStatusType
    {
        public ExaminationStatusType()
        {
            TitleEventCurrentExamStatusTypes = new HashSet<TitleEvent>();
            TitleEventOriginalExamStatusTypes = new HashSet<TitleEvent>();
        }

        public int ExaminationStatusTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public ICollection<TitleEvent> TitleEventCurrentExamStatusTypes { get; set; }

        public ICollection<TitleEvent> TitleEventOriginalExamStatusTypes { get; set; }
    }
}