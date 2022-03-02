using Asaas.Api.Dotnet.Clients;
using Asaas.Api.Dotnet.Models.Invoices;
using Microsoft.AspNetCore.Mvc;

namespace Asaas.Api.Dotnet.Example.Controllers
{
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        [HttpPost]
        [Route("invoices")]
        public async Task<IActionResult> CreateCreditCardPayment([FromBody] ScheduleInvoiceRequest request)
        {
            try
            {
                var asaasClient = new AsaasClient("0a65c68bcaf325b8aa2f1a688a8fc1234b1c0ffe1c91bdf4ff06dd2b37450df4", false);
                var response = await asaasClient.Invoices.ScheduleInvoiceAsync(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}