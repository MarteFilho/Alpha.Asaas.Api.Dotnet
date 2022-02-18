using Asaas.Api.Dotnet.Http;
using Asaas.Api.Dotnet.Http.Interfaces;

namespace Asaas.Api.Dotnet.Clients
{
    public class AsaasClient
    {
        private readonly IApiConnector _apiConnector;
        public AsaasClient(string accessToken, bool sandbox)
        {
            _apiConnector = new ApiConnector(sandbox ? AsaasUrls.ApiV3Sandbox : AsaasUrls.ApiV3Production, accessToken);
            Customers = new CustomersClient(_apiConnector);
            Payments = new PaymentsClient(_apiConnector);
        }
        public CustomersClient Customers { get;}
        public PaymentsClient Payments { get; }
    }
}