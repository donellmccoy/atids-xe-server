using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using TheFund.AtidsXe.Blazor.Server.Options;

namespace TheFund.AtidsXe.Blazor.Server.Factories
{
    public static class GraphQLClientFactory
    {
        public static GraphQLHttpClient Create(GraphQLServiceOptions options)
        {
            var client = new GraphQLHttpClient(options.BaseUrl, new NewtonsoftJsonSerializer());
            client.Options.UseWebSocketForQueriesAndMutations = options.UseWebSocketForQueriesAndMutations;

            return client;
        }
    }
}
