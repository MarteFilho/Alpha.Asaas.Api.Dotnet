using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Models.Requests;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Payment
{
    public record CreditCard : RequestParams
    {
        [BodyParameter("holderName")]
        [JsonProperty("holderName")]
        public string HolderName { get; set; }

        [BodyParameter("number")]
        [JsonProperty("number")]
        public string Number { get; set; }

        [BodyParameter("expiryMonth")]
        [JsonProperty("expiryMonth")]
        public string ExpiryMonth { get; set; }

        [BodyParameter("expiryYear")]
        [JsonProperty("expiryYear")]
        public string ExpiryYear { get; set; }

        [BodyParameter("ccv")]
        [JsonProperty("ccv")]
        public string Ccv { get; set; }
    }
}