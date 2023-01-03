using Asaas.Api.Dotnet.Http.Interfaces;
using Asaas.Api.Dotnet.Models.Requests.Payments;
using Asaas.Api.Dotnet.Models.Responses;
using Asaas.Api.Dotnet.Models.Responses.Payments;

namespace Asaas.Api.Dotnet.Clients
{
    public class PaymentsClient : ApiClient
    {
        public PaymentsClient(IApiConnector apiConnector) : base(apiConnector) { }

        public async Task<Response<CreatePixPaymentResponse>> CreatePixPaymentAsync(CreatePixPaymentRequest request)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            return await Api.PostAsync<CreatePixPaymentResponse>(AsaasUrls.Payments(), null, request.BuildBodyParameters());
        }

        public async Task<Response<GetPixQrCodeResponse>> GetPixQrCodeAsync(string id)
        {
            ArgumentNullException.ThrowIfNull(id, nameof(id));
            return await Api.GetAsync<GetPixQrCodeResponse>(AsaasUrls.PixQrCode(id), null);
        }

        public async Task<Response<CreateBilletPaymentResponse>> CreateBilletPaymentAsync(CreateBilletPaymentRequest request)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            return await Api.PostAsync<CreateBilletPaymentResponse>(AsaasUrls.Payments(), null, request.BuildBodyParameters());
        }

        public async Task<Response<GetBilletIdentificationFieldResponse>> GetBilletIdentificationFieldAsync(string id)
        {
            ArgumentNullException.ThrowIfNull(id, nameof(id));
            return await Api.GetAsync<GetBilletIdentificationFieldResponse>(AsaasUrls.BilletIdentificationField(id), null);
        }


        public async Task<Response<CreateCreditCardPaymentResponse>> CreateCreditCardPaymentAsync(CreateCreditCardPaymentRequest request)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            return await Api.PostAsync<CreateCreditCardPaymentResponse>(AsaasUrls.Payments(), null, request.BuildBodyParameters());
        }

        public async Task<Response<CreateCreditCardInstallmentPaymentResponse>> CreateCreditCardInstallmentPaymentAsync(CreateCreditCardInstallmentPaymentRequest request)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            return await Api.PostAsync<CreateCreditCardInstallmentPaymentResponse>(AsaasUrls.Payments(), null, request.BuildBodyParameters());
        }
    }
}