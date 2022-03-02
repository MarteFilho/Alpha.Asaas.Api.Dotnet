using Asaas.Api.Dotnet.Http.Interfaces;
using Asaas.Api.Dotnet.Models.Requests.Clients;
using Asaas.Api.Dotnet.Models.Responses;
using Asaas.Api.Dotnet.Models.Responses.Clients;

namespace Asaas.Api.Dotnet.Clients
{
    public class CustomersClient : ApiClient
    {
        public CustomersClient(IApiConnector apiConnector) : base(apiConnector)
        {
        }

        public async Task<Response<CreateClientResponse>> CreateClientAsync(CreateClientRequest request)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            return await Api.PostAsync<CreateClientResponse>(AsaasUrls.Customers(), null, request.BuildBodyParameters());
        }

        public async Task<Response<SearchClientsResponse>> SearchClientAsync(SearchClientsRequest request)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            return await Api.GetAsync<SearchClientsResponse>(AsaasUrls.Customers(), request.BuildQueryParameters());
        }
    }
}