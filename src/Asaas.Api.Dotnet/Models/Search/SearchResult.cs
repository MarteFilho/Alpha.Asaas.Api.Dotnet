using Asaas.Api.Dotnet.Models.Responses;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Search
{
    public abstract class SearchResult : DefaultResponse
    {
        public string Object { get; set; }
        public bool HasMore { get; set; }
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
    }
}