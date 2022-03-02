using Asaas.Api.Dotnet.Http.Interfaces;
using Asaas.Api.Dotnet.Models.Invoices;
using Asaas.Api.Dotnet.Models.Responses;

namespace Asaas.Api.Dotnet.Clients
{
    public class InvoicesClient : ApiClient
    {
        public InvoicesClient(IApiConnector apiConnector) : base(apiConnector)
        {
        }

        public async Task<Response<ScheduleInvoiceResponse>> ScheduleInvoiceAsync(ScheduleInvoiceRequest request)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            return await Api.PostAsync<ScheduleInvoiceResponse>(AsaasUrls.Invoices(), null, request.BuildBodyParameters());
        }
    }
}