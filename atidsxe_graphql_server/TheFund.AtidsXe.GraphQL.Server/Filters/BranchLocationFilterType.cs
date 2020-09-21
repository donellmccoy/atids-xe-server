using HotChocolate.Types.Filters;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Filters
{
    public class BranchLocationFilterType : FilterInputType<BranchLocation>
    {
        protected override void Configure(IFilterInputTypeDescriptor<BranchLocation> descriptor)
        {
            descriptor.BindFieldsExplicitly()
                .Filter(t => t.Description)
                .AllowNotIn();
        }
    }
}