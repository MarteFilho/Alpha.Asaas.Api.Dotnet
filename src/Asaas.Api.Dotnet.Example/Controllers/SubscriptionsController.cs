using Asaas.Api.Dotnet.Clients;
using Asaas.Api.Dotnet.Models.Requests.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace Asaas.Api.Dotnet.Example.Controllers
{
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        [HttpPost]
        [Route("subscriptions")]
        public async Task<IActionResult> CreateCreditCardSubscription([FromBody] CreateCreditCardSubscriptionRequest request)
        {
            try
            {
                var asaasClient = new AsaasClient("d802fe5eae61c789f4ccf33a8641226a9a0ac184d72ec0a9898ab1ccb97724a5", false);
                var response = await asaasClient.Subscriptions.CreateCreditCardSubscriptionAsync(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}