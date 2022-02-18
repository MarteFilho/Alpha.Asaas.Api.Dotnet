using Asaas.Api.Dotnet.Clients;
using Asaas.Api.Dotnet.Models.Requests.Payments;
using Microsoft.AspNetCore.Mvc;

namespace Asaas.Api.Dotnet.Example.Controllers
{
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        [HttpPost]
        [Route("payments")]
        public async Task<IActionResult> CreateCreditCardPayment([FromBody] CreateCreditCardPaymentRequest request)
        {
            try
            {
                var asaasClient = new AsaasClient("d802fe5eae61c789f4ccf33a8641226a9a0ac184d72ec0a9898ab1ccb97724a5", false);
                var response = await asaasClient.Payments.CreateCreditCardPaymentAsync(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("payments-installments")]
        public async Task<IActionResult> CreateCreditCardInstallmentPayment([FromBody] CreateCreditCardInstallmentPaymentRequest request)
        {
            try
            {
                var asaasClient = new AsaasClient("9ffdb588158ed7e1e319987af6e99ba57228eab869baf49a226979e815717497", true);
                var response = await asaasClient.Payments.CreateCreditCardInstallmentPaymentAsync(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}