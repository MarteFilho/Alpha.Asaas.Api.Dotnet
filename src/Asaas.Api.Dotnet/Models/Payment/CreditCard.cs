using Asaas.Api.Dotnet.Models.Requests;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Payment
{
    public class CreditCard : RequestParams
    {
        [BodyParam("holderName")]
        [JsonProperty("holderName")]
        public string HolderName { get; set; }

        [BodyParam("number")]
        [JsonProperty("number")]
        public string Number { get; set; }

        [BodyParam("expiryMonth")]
        [JsonProperty("expiryMonth")]
        public string ExpiryMonth { get; set; }

        [BodyParam("expiryYear")]
        [JsonProperty("expiryYear")]
        public string ExpiryYear { get; set; }

        [BodyParam("ccv")]
        [JsonProperty("ccv")]
        public string Ccv { get; set; }
    }
}