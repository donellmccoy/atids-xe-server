namespace TheFund.AtidsXe.Blazor.Server.Models.Requests
{
    public interface IRequest
    {
        object Variables { get; }
        string Query { get; }
        string OperationName { get; }
        object CacheKey { get; }
    }
}
