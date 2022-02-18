using Asaas.Api.Dotnet.Models.Search;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Responses.Clients
{
    public class SearchClientsResponse : SearchResult
    {
        [JsonProperty("data")]
        public List<Client> Clients { get; set; }
    }
}