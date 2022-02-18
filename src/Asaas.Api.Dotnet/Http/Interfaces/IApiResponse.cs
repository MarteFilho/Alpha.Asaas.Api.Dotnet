namespace Asaas.Api.Dotnet.Http.Interfaces
{
    public interface IApiResponse<out T>
    {
        T? Body { get; }

        IResponse Response { get; }
    }
}