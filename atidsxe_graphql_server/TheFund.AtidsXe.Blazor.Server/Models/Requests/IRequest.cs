namespace TheFund.AtidsXe.Blazor.Server.Models.Requests
{
    public interface IRequest
    {
        (string, int)[] Variables { get; }
    }
}
