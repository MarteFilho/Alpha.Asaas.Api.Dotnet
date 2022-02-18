using Asaas.Api.Dotnet.Clients;
using Asaas.Api.Dotnet.Models.Requests.Clients;
using Asaas.Api.Dotnet.Models.Requests.Payments;
using Microsoft.AspNetCore.Mvc;

namespace Assas.ApiDotnet.Example.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "customers")]
    public async Task<IActionResult> CreateClient([FromBody] CreateClientRequest request)
    {
        var asaasClient = new AsaasClient("d802fe5eae61c789f4ccf33a8641226a9a0ac184d72ec0a9898ab1ccb97724a5", true);
        var response = await asaasClient.Customers.CreateClientAsync(request);
        return Ok(response);
    }

    [HttpGet(Name = "customers")]
    public async Task<IActionResult> SearchClient([FromQuery] SearchClientsRequest request)
    {
        var asaasClient = new AsaasClient("d802fe5eae61c789f4ccf33a8641226a9a0ac184d72ec0a9898ab1ccb97724a5", true);
        var response = await asaasClient.Customers.SearchClientAsync(request);
        return Ok(response);
    }
}
