using System.Reflection;
using Asaas.Api.Dotnet.Http.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Asaas.Api.Dotnet.Http;
public class NewtonsoftJSONSerializer : IJsonSerializer
{
    private readonly JsonSerializerSettings _serializerSettings;

    public NewtonsoftJSONSerializer()
    {
        var contractResolver = new PrivateFieldDefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        };

        _serializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = contractResolver
        };
    }

    public IApiResponse<T> DeserializeResponse<T>(IResponse response)
    {
        if (
            response.ContentType?.Equals("application/json", StringComparison.Ordinal) is true || response.ContentType == null
          )
        {
            var body = JsonConvert.DeserializeObject<T>(response.Body as string ?? "", _serializerSettings);
            return new ApiResponse<T>(response, body!);
        }
        return new ApiResponse<T>(response);
    }

    public void SerializeRequest(IRequest request)
    {
        if (request.Body is string || request.Body is Stream || request.Body is HttpContent || request.Body is null)
            return;

        request.Body = JsonConvert.SerializeObject(request.Body, _serializerSettings);
    }

    private class PrivateFieldDefaultContractResolver : DefaultContractResolver
    {
        protected override List<MemberInfo> GetSerializableMembers(Type objectType)
        {
            var list = base.GetSerializableMembers(objectType);
            list.AddRange(objectType.GetProperties(BindingFlags.NonPublic));
            return list;
        }
    }
}