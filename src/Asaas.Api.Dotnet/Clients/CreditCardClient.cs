using Asaas.Api.Dotnet.Http.Interfaces;
using Asaas.Api.Dotnet.Models.Requests.CreditCards;
using Asaas.Api.Dotnet.Models.Responses;
using Asaas.Api.Dotnet.Models.Responses.CreditCards;

namespace Asaas.Api.Dotnet.Clients
{
    public class CreditCardClient : ApiClient
    {
        public CreditCardClient(IApiConnector apiConnector) : base(apiConnector)
        {
        }

        public async Task<Response<TokenizeCreditCardResponse>> TokenizeCreditCardAsync(TokenizeCreditCardRequest request)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            return await Api.PostAsync<TokenizeCreditCardResponse>(AsaasUrls.TokenizeCreditCard(), null, request.BuildBodyParameters());
        }
    }
}