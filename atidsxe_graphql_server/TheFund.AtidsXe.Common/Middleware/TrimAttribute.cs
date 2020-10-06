using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using System;
using System.Reflection;
using TheFund.AtidsXe.Common.Extensions;

namespace TheFund.AtidsXe.Common.Middleware
{
    public class TrimAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
        {
            descriptor.Trim();
        }
    }
}
