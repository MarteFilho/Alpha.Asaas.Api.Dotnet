using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Models.Payment;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Requests.CreditCards
{
    public record TokenizeCreditCardRequest : RequestParams
    {
        [BodyParameter("customer")]
        [JsonProperty("customer")]
        public string Customer { get; set; }
        [BodyParameter("creditCard")]
        [JsonProperty("creditCard")]
        public CreditCard CreditCard { get; set; }
        [BodyParameter("creditCardHolderInfo")]
        [JsonProperty("creditCardHolderInfo")]
        public CreditCardHolderInfo CreditCardHolderInfo { get; set; }
    }
}