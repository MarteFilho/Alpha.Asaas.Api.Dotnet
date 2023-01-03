using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Responses.Payments
{
    public class GetPixQrCodeResponse : DefaultResponse
    {
        [JsonProperty("encodedImage")]
        public string EncodedImage { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }
}