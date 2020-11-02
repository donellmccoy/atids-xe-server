using GraphQL;

namespace TheFund.AtidsXe.Blazor.Server.Options
{
    public class GraphQLServiceOptions
    {
        public static string SectionName => nameof(GraphQLServiceOptions);

        public string BaseUrl { get; set; }

        public bool UseWebSocketForQueriesAndMutations { get; set; }
    }

    public class SearchRequestOptions : GraphQLRequest
    {
        public static string SectionName => "SearchRequestOptions";
    }
}
