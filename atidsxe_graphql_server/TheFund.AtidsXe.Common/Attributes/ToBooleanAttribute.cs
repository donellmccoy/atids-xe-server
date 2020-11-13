using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using System.Reflection;
using TheFund.AtidsXe.Common.Extensions;

namespace TheFund.AtidsXe.Common.Attributes
{
    public class ToBooleanAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
        {
            descriptor.ToBoolean();
        }
    }
}
