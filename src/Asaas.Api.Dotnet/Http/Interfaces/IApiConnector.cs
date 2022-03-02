using System.Net;
using Asaas.Api.Dotnet.Models.Responses;

namespace Asaas.Api.Dotnet.Http.Interfaces
{
    public interface IApiConnector
    {
        Task<Response<T>> GetAsync<T>(Uri uri) where T : DefaultResponse;
        Task<Response<T>> GetAsync<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse;
        Task<HttpStatusCode> GetAsync(Uri uri, IDictionary<string, string>? parameters, object? body);

        Task<Response<T>> PostAsync<T>(Uri uri) where T : DefaultResponse;
        Task<Response<T>> PostAsync<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse;
        Task<Response<T>> PostAsync<T>(Uri uri, IDictionary<string, string>? parameters, object? body) where T : DefaultResponse;
        Task<Response<T>> PostAsync<T>(Uri uri, IDictionary<string, string>? parameters, object? body, Dictionary<string, string>? headers) where T : DefaultResponse;
        Task<HttpStatusCode> PostAsync(Uri uri, IDictionary<string, string>? parameters, object? body);

        Task<Response<T>> PutAsync<T>(Uri uri) where T : DefaultResponse;
        Task<Response<T>> PutAsync<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse;
        Task<Response<T>> PutAsync<T>(Uri uri, IDictionary<string, string>? parameters, object? body) where T : DefaultResponse;
        Task<HttpStatusCode> PutAsync(Uri uri, IDictionary<string, string>? parameters, object? body);
        Task<HttpStatusCode> PutRawAsync(Uri uri, IDictionary<string, string>? parameters, object? body);

        Task<Response<T>> DeleteAsync<T>(Uri uri) where T : DefaultResponse;
        Task<Response<T>> DeleteAsync<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse;
        Task<Response<T>> DeleteAsync<T>(Uri uri, IDictionary<string, string>? parameters, object? body) where T : DefaultResponse;
        Task<HttpStatusCode> DeleteAsync(Uri uri, IDictionary<string, string>? parameters, object? body);

        Task<Response<T>> SendApiRequestAsync<T>(
          Uri uri, HttpMethod method,
          IDictionary<string, string>? parameters = null,
          object? body = null,
          IDictionary<string, string>? headers = null) where T : DefaultResponse;

        void SetRequestTimeout(TimeSpan timeout);
    }
}