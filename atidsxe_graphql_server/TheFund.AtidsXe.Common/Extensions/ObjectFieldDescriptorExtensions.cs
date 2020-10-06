using HotChocolate.Types;

namespace TheFund.AtidsXe.Common.Extensions
{
    public static class ObjectFieldDescriptorExtensions
    {
        public static IObjectFieldDescriptor Trim(this IObjectFieldDescriptor descriptor)
        {
            return descriptor.Use(next => async context =>
            {
                await next(context);

                if (context.Result is string s)
                {
                    context.Result = s?.Trim();
                }
            });
        }

        public static IObjectFieldDescriptor UseUpperCase(this IObjectFieldDescriptor descriptor)
        {
            return descriptor.Use(next => async context =>
            {
                await next(context);

                if (context.Result is string s)
                {
                    context.Result = s.ToUpperInvariant();
                }
            });
        }
    }
}
