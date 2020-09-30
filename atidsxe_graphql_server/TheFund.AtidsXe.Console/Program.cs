using System;
using System.Text.Json;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace TheFund.AtidsXe.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new GraphQLHttpClient("http://localhost:5002/graphql", new NewtonsoftJsonSerializer());
            var request = new GraphQLRequest();

            request.TryAdd("id", "ZmlsZVJlZmVyZW5jZXM");
            
            var response = await client.SendQueryAsync<object>(request);
        }
    }
}
