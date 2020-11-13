using GraphQL;

namespace TheFund.AtidsXe.Blazor.Server.Factories
{
    public static class GraphQLRequestFactory
    {
        public static GraphQLRequest Create(string query, string operationName = null, object variables = null)
        {
            return new GraphQLRequest
            {
                Query = query,
                OperationName = operationName,
                Variables = variables
            };
        }
    }
}
