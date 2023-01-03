using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Responses.Subscriptions
{
    public class DeleteCreditCardSubscriptionResponse : DefaultResponse
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}