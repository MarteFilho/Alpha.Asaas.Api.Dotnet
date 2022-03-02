namespace Asaas.Api.Dotnet.Http.Interfaces
{
    public interface IHttpClient : IDisposable
    {
        Task<IResponse> SendRequest(IRequest request);
        void SetRequestTimeout(TimeSpan timeout);
    }
}