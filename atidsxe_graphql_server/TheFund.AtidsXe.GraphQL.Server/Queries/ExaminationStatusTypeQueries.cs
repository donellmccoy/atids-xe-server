using HotChocolate;
using HotChocolate.Types;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class ExaminationStatusTypeQueries
    {
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ExaminationStatusType> GetExaminationStatusTypes([Service] ATIDSXEContext context)
        {
            return context.ExaminationStatusType;
        }

        [UseSingleOrDefault]
        [UseSelection]
        public IQueryable<ExaminationStatusType> GetExaminationStatusType(int examinationStatusTypeId, [Service] ATIDSXEContext context)
        {
            return context.ExaminationStatusType.Where(p => p.ExaminationStatusTypeId == examinationStatusTypeId);
        }
    }
}
