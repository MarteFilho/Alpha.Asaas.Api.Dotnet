using System.Net;
using Asaas.Api.Dotnet.Http.Interfaces;
using Asaas.Api.Dotnet.Models.Responses;

namespace Asaas.Api.Dotnet.Http;
public class ApiConnector : IApiConnector
{
    private readonly Uri _baseAddress;
    private readonly string _accessToken;
    private readonly IJsonSerializer _jsonSerializer;
    private readonly IHttpClient _httpClient;

    public event EventHandler<IResponse>? ResponseReceived;

    public ApiConnector(Uri baseAddress, string accessToken) :
      this(baseAddress, accessToken, new NewtonsoftJSONSerializer(), new HttpClient())
    { }
    public ApiConnector(
      Uri baseAddress,
      string accessToken,
      IJsonSerializer jsonSerializer,
      IHttpClient httpClient)
    {
        _baseAddress = baseAddress;
        _accessToken = accessToken;
        _jsonSerializer = jsonSerializer;
        _httpClient = httpClient;
    }

    public Task<Response<T>> Delete<T>(Uri uri) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Delete);
    }

    public Task<Response<T>> Delete<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Delete, parameters);
    }

    public Task<Response<T>> Delete<T>(Uri uri, IDictionary<string, string>? parameters, object? body) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Delete, parameters, body);
    }

    public async Task<HttpStatusCode> Delete(Uri uri, IDictionary<string, string>? parameters, object? body)
    {
        var response = await SendApiRequestDetailed(uri, HttpMethod.Delete, parameters, body).ConfigureAwait(false);
        return response.StatusCode;
    }

    public Task<Response<T>> GetAsync<T>(Uri uri) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Get);
    }

    public Task<Response<T>> GetAsync<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Get, parameters);
    }

    public async Task<HttpStatusCode> GetAsync(Uri uri, IDictionary<string, string>? parameters, object? body)
    {
        var response = await SendApiRequestDetailed(uri, HttpMethod.Get, parameters, body).ConfigureAwait(false);
        return response.StatusCode;
    }

    public Task<Response<T>> PostAsync<T>(Uri uri) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Post);
    }

    public Task<Response<T>> PostAsync<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Post, parameters);
    }

    public Task<Response<T>> PostAsync<T>(Uri uri, IDictionary<string, string>? parameters, object? body) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Post, parameters, body);
    }

    public Task<Response<T>> PostAsync<T>(Uri uri, IDictionary<string, string>? parameters, object? body, Dictionary<string, string>? headers) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Post, parameters, body, headers);
    }

    public async Task<HttpStatusCode> PostAsync(Uri uri, IDictionary<string, string>? parameters, object? body)
    {
        var response = await SendApiRequestDetailed(uri, HttpMethod.Post, parameters, body).ConfigureAwait(false);
        return response.StatusCode;
    }

    public Task<Response<T>> Put<T>(Uri uri) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Put);
    }

    public Task<Response<T>> Put<T>(Uri uri, IDictionary<string, string>? parameters) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Put, parameters);
    }

    public Task<Response<T>> Put<T>(Uri uri, IDictionary<string, string>? parameters, object? body) where T : DefaultResponse
    {
        return SendApiRequest<T>(uri, HttpMethod.Put, parameters, body);
    }

    public async Task<HttpStatusCode> Put(Uri uri, IDictionary<string, string>? parameters, object? body)
    {
        var response = await SendApiRequestDetailed(uri, HttpMethod.Put, parameters, body).ConfigureAwait(false);
        return response.StatusCode;
    }

    public async Task<HttpStatusCode> PutRaw(Uri uri, IDictionary<string, string>? parameters, object? body)
    {
        var response = await SendRawRequest(uri, HttpMethod.Put, parameters, body).ConfigureAwait(false);
        return response.StatusCode;
    }

    public void SetRequestTimeout(TimeSpan timeout)
    {
        _httpClient.SetRequestTimeout(timeout);
    }

    private IRequest CreateRequest(
        Uri uri,
        HttpMethod method,
        IDictionary<string, string>? parameters,
        object? body,
        IDictionary<string, string>? headers
      )
    {
        if (headers == null)
        {
            headers = new Dictionary<string, string>
            {
                { "access_token", _accessToken }
            };
        }
        else
        {
            headers.Add("access_token", _accessToken);
        }

        return new Request(
          _baseAddress,
          uri,
          method,
          headers,
          parameters ?? new Dictionary<string, string>())
        {
            Body = body
        };
    }

    private async Task<IApiResponse<T>> DoSerializedRequest<T>(IRequest request)
    {
        _jsonSerializer.SerializeRequest(request);
        var response = await DoRequest(request).ConfigureAwait(false);
        return _jsonSerializer.DeserializeResponse<T>(response);
    }

    private async Task<IResponse> DoRequest(IRequest request)
    {
        IResponse response = await _httpClient.DoRequest(request).ConfigureAwait(false);
        ResponseReceived?.Invoke(this, response);
        return response;
    }

    public Task<IResponse> SendRawRequest(
        Uri uri,
        HttpMethod method,
        IDictionary<string, string>? parameters = null,
        object? body = null,
        IDictionary<string, string>? headers = null
      )
    {
        var request = CreateRequest(uri, method, parameters, body, headers);
        return DoRequest(request);
    }

    public async Task<Response<T>> SendApiRequest<T>(
        Uri uri,
        HttpMethod method,
        IDictionary<string, string>? parameters = null,
        object? body = null,
        IDictionary<string, string>? headers = null
      ) where T : DefaultResponse
    {
        var request = CreateRequest(uri, method, parameters, body, headers);
        IApiResponse<T> apiResponse = await DoSerializedRequest<T>(request).ConfigureAwait(false);
        if (!apiResponse.Response.Success)
            return new Response<T>(apiResponse.Body?.Errors);
        return new Response<T>(apiResponse.Body)!;
    }

    public async Task<IResponse> SendApiRequestDetailed(
        Uri uri,
        HttpMethod method,
        IDictionary<string, string>? parameters = null,
        object? body = null,
        IDictionary<string, string>? headers = null
      )
    {
        var request = CreateRequest(uri, method, parameters, body, headers);
        var response = await DoSerializedRequest<object>(request).ConfigureAwait(false);
        return response.Response;
    }
}