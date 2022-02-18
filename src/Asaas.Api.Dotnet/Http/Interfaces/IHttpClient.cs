namespace Asaas.Api.Dotnet.Http.Interfaces
{
    public interface IHttpClient : IDisposable
    {
        Task<IResponse> DoRequest(IRequest request);
        void SetRequestTimeout(TimeSpan timeout);
    }
}