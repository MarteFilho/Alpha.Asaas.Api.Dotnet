using System.Text;
using Asaas.Api.Dotnet.Http.Interfaces;
using Asaas.Api.Dotnet.Extensions;

namespace Asaas.Api.Dotnet.Http
{
    public class HttpClient : IHttpClient
    {
        private readonly HttpMessageHandler? _httpMessageHandler;
        private readonly System.Net.Http.HttpClient _httpClient;

        public HttpClient()
        {
            _httpClient = new System.Net.Http.HttpClient();
        }

        public HttpClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResponse> SendRequest(IRequest request)
        {
            using HttpRequestMessage requestMessage = BuildRequestMessage(request);
            var responseMessage = await _httpClient
                    .SendAsync(requestMessage, HttpCompletionOption.ResponseContentRead)
                    .ConfigureAwait(false);

            return await BuildResponse(responseMessage).ConfigureAwait(false);
        }

        private static async Task<IResponse> BuildResponse(HttpResponseMessage httpResponseMessage)
        {
            using var content = httpResponseMessage.Content;
            var headers = httpResponseMessage.Headers.ToDictionary(header => header.Key, header => header.Value.First());
            var body = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            var contentType = content.Headers?.ContentType?.MediaType;

            return new Response(headers)
            {
                ContentType = contentType,
                StatusCode = httpResponseMessage.StatusCode,
                Body = body,
                Success = httpResponseMessage.IsSuccessStatusCode
            };
        }

        private static HttpRequestMessage BuildRequestMessage(IRequest request)
        {
            var fullUri = new Uri(request.BaseAddress, request.Endpoint).ApplyParameters(request.Parameters);
            var requestMsg = new HttpRequestMessage(request.Method, fullUri);
            foreach (var header in request.Headers)
            {
                requestMsg.Headers.Add(header.Key, header.Value);
            }

            switch (request.Body)
            {
                case HttpContent body:
                    requestMsg.Content = body;
                    break;
                case string body:
                    requestMsg.Content = new StringContent(body, Encoding.UTF8, "application/json");
                    break;
                case Stream body:
                    requestMsg.Content = new StreamContent(body);
                    break;
            }

            return requestMsg;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _httpClient?.Dispose();
                _httpMessageHandler?.Dispose();
            }
        }

        public void SetRequestTimeout(TimeSpan timeout)
        {
            _httpClient.Timeout = timeout;
        }
    }
}