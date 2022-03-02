using Asaas.Api.Dotnet.Http.Interfaces;

namespace Asaas.Api.Dotnet.Clients
{
    public abstract class ApiClient
    {
        protected ApiClient(IApiConnector apiConnector)
        {
            ArgumentNullException.ThrowIfNull(apiConnector, nameof(apiConnector));
            Api = apiConnector;
        }

        protected IApiConnector Api { get; set; }
    }
}