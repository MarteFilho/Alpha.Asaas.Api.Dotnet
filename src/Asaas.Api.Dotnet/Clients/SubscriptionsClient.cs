using Asaas.Api.Dotnet.Http.Interfaces;
using Asaas.Api.Dotnet.Models.Requests.Subscriptions;
using Asaas.Api.Dotnet.Models.Responses;
using Asaas.Api.Dotnet.Models.Responses.Subscriptions;

namespace Asaas.Api.Dotnet.Clients
{
    public class SubscriptionsClient : ApiClient
    {
        public SubscriptionsClient(IApiConnector apiConnector) : base(apiConnector)
        {
        }

        public async Task<Response<CreateCreditCardSubscriptionResponse>> CreateCreditCardSubscriptionAsync(CreateCreditCardSubscriptionRequest request)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            return await Api.PostAsync<CreateCreditCardSubscriptionResponse>(AsaasUrls.Subscriptions(), null, request.BuildBodyParameters());
        }

        public async Task<Response<CreateCreditCardSubscriptionResponse>> DeleteCreditCardSubscriptionAsync(string id)
        {
            ArgumentNullException.ThrowIfNull(id, nameof(id));
            return await Api.DeleteAsync<CreateCreditCardSubscriptionResponse>(AsaasUrls.Subscriptions(id));
        }
    }
}