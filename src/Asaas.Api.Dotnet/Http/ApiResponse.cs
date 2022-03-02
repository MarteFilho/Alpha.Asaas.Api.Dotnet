using Asaas.Api.Dotnet.Http.Interfaces;

namespace Asaas.Api.Dotnet.Http;
public class ApiResponse<T> : IApiResponse<T>
{
    public ApiResponse(IResponse response, T? body = default)
    {
        Body = body;
        Response = response;
    }

    public T? Body { get; set; }

    public IResponse Response { get; set; }
}