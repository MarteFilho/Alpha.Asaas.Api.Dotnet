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
        [Route("payments/pix")]
        public async Task<IActionResult> CreatePixPayment([FromBody] CreatePixPaymentRequest request)
        {
            try
            {
                var asaasClient = new AsaasClient("$aact_YTU5YTE0M2M2N2I4MTliNzk0YTI5N2U5MzdjNWZmNDQ6OjAwMDAwMDAwMDAwMDAxMzQ0NTA6OiRhYWNoXzY3NTBlYzdiLTc0ODUtNDY4Ni1hMzhkLWZmMWQ2NDY2YWVjMw==", false);
                var response = await asaasClient.Payments.CreatePixPaymentAsync(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("payments/pix/qrcode")]
        public async Task<IActionResult> GetPixQrCode([FromQuery] string id)
        {
            try
            {
                var asaasClient = new AsaasClient("$aact_YTU5YTE0M2M2N2I4MTliNzk0YTI5N2U5MzdjNWZmNDQ6OjAwMDAwMDAwMDAwMDAxMzQ0NTA6OiRhYWNoXzY3NTBlYzdiLTc0ODUtNDY4Ni1hMzhkLWZmMWQ2NDY2YWVjMw==", false);
                var response = await asaasClient.Payments.GetPixQrCodeAsync(id);
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