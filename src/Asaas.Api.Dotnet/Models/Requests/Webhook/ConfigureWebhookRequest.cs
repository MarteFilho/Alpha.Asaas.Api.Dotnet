using Asaas.Api.Dotnet.Attributes;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Requests.Webhook
{
    public record ConfigureWebhookRequest : RequestParams
    {
        [BodyParameter("url")]
        [JsonProperty("url")]
        public string Url { get; set; }
        [BodyParameter("email")]
        [JsonProperty("email")]
        public string Email { get; set; }
        [BodyParameter("interrupted")]
        [JsonProperty("interrupted")]
        public bool Interrupted { get; set; }
        [BodyParameter("enabled")]
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [BodyParameter("apiVersion")]
        [JsonProperty("apiVersion")]
        public int ApiVersion { get; set; }
        [BodyParameter("AuthToken")]
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }
    }
}