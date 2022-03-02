using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Models.Requests;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Payment
{
    public record CreditCardHolderInfo : RequestParams
    {
        [BodyParameter("name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [BodyParameter("email")]
        [JsonProperty("email")]
        public string Email { get; set; }

        [BodyParameter("cpfCnpj")]
        [JsonProperty("cpfCnpj")]
        public string CpfCnpj { get; set; }

        [BodyParameter("postalCode")]
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [BodyParameter("addressNumber")]
        [JsonProperty("addressNumber")]
        public string AddressNumber { get; set; }

        [BodyParameter("addressComplement")]
        [JsonProperty("addressComplement")]
        public string? AddressComplement { get; set; }

        [BodyParameter("phone")]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [BodyParameter("mobilePhone")]
        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }
    }
}