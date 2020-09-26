using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ExaminationStatusType
    {
        public ExaminationStatusType()
        {
            TitleEventCurrentExamStatusType = new HashSet<TitleEvent>();
            TitleEventOriginalExamStatusType = new HashSet<TitleEvent>();
        }

        public int ExaminationStatusTypeId { get; set; }

        public string Description { get; set; }

        public ICollection<TitleEvent> TitleEventCurrentExamStatusType { get; set; }

        public ICollection<TitleEvent> TitleEventOriginalExamStatusType { get; set; }
    }
}