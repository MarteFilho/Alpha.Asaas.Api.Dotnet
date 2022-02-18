namespace Asaas.Api.Dotnet.Http.Interfaces
{
    public interface IJsonSerializer
    {
        void SerializeRequest(IRequest request);
        IApiResponse<T> DeserializeResponse<T>(IResponse response);
    }
}