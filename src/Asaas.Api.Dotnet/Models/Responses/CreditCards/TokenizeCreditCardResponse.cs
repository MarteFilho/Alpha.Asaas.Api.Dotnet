using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Responses.CreditCards
{
    public class TokenizeCreditCardResponse : DefaultResponse
    {
        [JsonProperty("creditCardNumber")]
        public string CreditCardNumber { get; set; }

        [JsonProperty("creditCardBrand")]
        public string CreditCardBrand { get; set; }

        [JsonProperty("creditCardToken")]
        public string CreditCardToken { get; set; }
    }
}