using Asaas.Api.Dotnet.Clients;
using Asaas.Api.Dotnet.Models.Requests.Clients;
using Microsoft.AspNetCore.Mvc;

namespace Asaas.Api.Dotnet.Example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        [HttpGet(Name = "clients")]
        public async Task<IActionResult> SearchClients([FromQuery] SearchClientsRequest request)
        {
            var asaasClient = new AsaasClient("d802fe5eae61c789f4ccf33a8641226a9a0ac184d72ec0a9898ab1ccb97724a5", true);
            var response = await asaasClient.Customers.SearchClientAsync(request);
            return Ok(response);
        }
    }
}