using GraphQL;
using System.Linq;

namespace TheFund.AtidsXe.Blazor.Server.Factories
{
    public static class GraphQLRequestFactory
    {
        public static GraphQLRequest Create(string query, string operationName = null, params (string, object)[] variables)
        {
            return new GraphQLRequest
            {
                Query = query,
                OperationName = operationName,
                Variables = variables.ToDictionary(variable => variable.Item1, variable => variable.Item2)
            };
        }

        public static GraphQLRequest Create(string query, string operationName = null, params (string, int)[] variables)
        {
            return new GraphQLRequest
            {
                Query = query,
                OperationName = operationName,
                Variables = variables.ToDictionary(variable => variable.Item1, variable => variable.Item2)
            };
        }
    }

}
