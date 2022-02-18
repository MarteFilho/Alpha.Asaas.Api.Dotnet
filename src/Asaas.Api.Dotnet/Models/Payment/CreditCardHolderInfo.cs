using Asaas.Api.Dotnet.Models.Requests;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Payment
{
    public class CreditCardHolderInfo : RequestParams
    {
        [BodyParam("name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [BodyParam("email")]
        [JsonProperty("email")]
        public string Email { get; set; }

        [BodyParam("cpfCnpj")]
        [JsonProperty("cpfCnpj")]
        public string CpfCnpj { get; set; }

        [BodyParam("postalCode")]
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [BodyParam("addressNumber")]
        [JsonProperty("addressNumber")]
        public string AddressNumber { get; set; }

        [BodyParam("addressComplement")]
        [JsonProperty("addressComplement")]
        public string? AddressComplement { get; set; }

        [BodyParam("phone")]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [BodyParam("mobilePhone")]
        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }
    }
}