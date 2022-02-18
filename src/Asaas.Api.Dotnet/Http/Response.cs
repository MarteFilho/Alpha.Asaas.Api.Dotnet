using System.Collections.ObjectModel;
using System.Net;
using Asaas.Api.Dotnet.Http.Interfaces;

namespace Asaas.Api.Dotnet.Http
{
    public class Response : IResponse
    {
        public Response(IDictionary<string, string> headers)
        {
            Headers = new ReadOnlyDictionary<string, string>(headers);
        }

        public object? Body { get; set; }

        public IReadOnlyDictionary<string, string> Headers { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string? ContentType { get; set; }
        public bool Success { get; set; }
    }
}