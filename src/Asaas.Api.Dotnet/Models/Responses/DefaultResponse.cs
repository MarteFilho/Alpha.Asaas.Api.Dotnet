using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Responses
{
    public class DefaultResponse
    {
        [JsonProperty("errors")]
        public List<Error> Errors { get; set; }
    }
}