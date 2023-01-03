using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Responses.Payments
{
    public class GetBilletIdentificationFieldResponse : DefaultResponse
    {
        [JsonProperty("identificationField")]
        public string IdentificationField { get; set; }

        [JsonProperty("nossoNumero")]
        public string NossoNumero { get; set; }

        [JsonProperty("barCode")]
        public string BarCode { get; set; }
    }
}