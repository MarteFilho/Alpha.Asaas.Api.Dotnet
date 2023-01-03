using Asaas.Api.Dotnet.Http;
using Asaas.Api.Dotnet.Http.Interfaces;

namespace Asaas.Api.Dotnet.Clients
{
    public class AsaasClient
    {
        private readonly IApiConnector _apiConnector;
        public AsaasClient(string accessToken, bool sandbox)
        {
            ArgumentNullException.ThrowIfNull(accessToken, nameof(accessToken));
            ArgumentNullException.ThrowIfNull(sandbox, nameof(sandbox));
            _apiConnector = new ApiConnector(sandbox ? AsaasUrls.ApiV3Sandbox : AsaasUrls.ApiV3Production, accessToken);
            Customers = new CustomersClient(_apiConnector);
            Payments = new PaymentsClient(_apiConnector);
            Invoices = new InvoicesClient(_apiConnector);
            Subscriptions = new SubscriptionsClient(_apiConnector);
            CreditCards = new CreditCardClient(_apiConnector);
        }
        public CustomersClient Customers { get; }
        public PaymentsClient Payments { get; }
        public InvoicesClient Invoices { get; }
        public SubscriptionsClient Subscriptions { get; }
        public CreditCardClient CreditCards { get; set; }
    }
}