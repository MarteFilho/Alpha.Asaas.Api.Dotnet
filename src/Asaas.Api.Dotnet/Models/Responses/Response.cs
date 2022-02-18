namespace Asaas.Api.Dotnet.Models.Responses
{
    public class Response<T> where T : class
    {
        public T Data { get; set; }
        public List<Error> Errors { get; set; }
        public Response(T data)
        {
            Data = data;
        }
        public Response(List<Error> errors)
        {
            Errors = errors;
        }
    }
}