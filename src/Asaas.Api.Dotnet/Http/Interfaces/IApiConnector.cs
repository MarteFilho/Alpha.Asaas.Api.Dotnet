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

    Task<Response<T>> Put<T>(Uri uri) where T : DefaultResponse;
    Task<Response<T>> Put<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse;
    Task<Response<T>> Put<T>(Uri uri, IDictionary<string, string>? parameters, object? body) where T : DefaultResponse;
    Task<HttpStatusCode> Put(Uri uri, IDictionary<string, string>? parameters, object? body);
    Task<HttpStatusCode> PutRaw(Uri uri, IDictionary<string, string>? parameters, object? body);

    Task<Response<T>> Delete<T>(Uri uri) where T : DefaultResponse;
    Task<Response<T>> Delete<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse;
    Task<Response<T>> Delete<T>(Uri uri, IDictionary<string, string>? parameters, object? body) where T : DefaultResponse;
    Task<HttpStatusCode> Delete(Uri uri, IDictionary<string, string>? parameters, object? body);

    Task<Response<T>> SendApiRequest<T>(
      Uri uri, HttpMethod method,
      IDictionary<string, string>? parameters = null,
      object? body = null,
      IDictionary<string, string>? headers = null) where T : DefaultResponse;

    void SetRequestTimeout(TimeSpan timeout);
  }
}