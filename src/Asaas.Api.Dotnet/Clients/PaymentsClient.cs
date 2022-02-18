using Asaas.Api.Dotnet.Http.Interfaces;
using Asaas.Api.Dotnet.Models.Requests.Payments;
using Asaas.Api.Dotnet.Models.Responses;
using Asaas.Api.Dotnet.Models.Responses.Payments;

namespace Asaas.Api.Dotnet.Clients
{
    public class PaymentsClient : ApiClient
    {
        public PaymentsClient(IApiConnector apiConnector) : base(apiConnector) { }

        public async Task<Response<CreateCreditCardPaymentResponse>> CreateCreditCardPaymentAsync(CreateCreditCardPaymentRequest request)
        {
            return await Api.PostAsync<CreateCreditCardPaymentResponse>(AsaasUrls.Payments(), null, request.BuildBodyParams());
        }

        public async Task<Response<CreateCreditCardInstallmentPaymentResponse>> CreateCreditCardInstallmentPaymentAsync(CreateCreditCardInstallmentPaymentRequest request)
        {
            return await Api.PostAsync<CreateCreditCardInstallmentPaymentResponse>(AsaasUrls.Payments(), null, request.BuildBodyParams());
        }
    }
}