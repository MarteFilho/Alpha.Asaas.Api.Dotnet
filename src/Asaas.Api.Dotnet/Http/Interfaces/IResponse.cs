using System.Net;

namespace Asaas.Api.Dotnet.Http.Interfaces
{
    public interface IResponse
    {
        object? Body { get; }

        IReadOnlyDictionary<string, string> Headers { get; }

        HttpStatusCode StatusCode { get; }

        string? ContentType { get; }
        bool Success { get; }
    }
}