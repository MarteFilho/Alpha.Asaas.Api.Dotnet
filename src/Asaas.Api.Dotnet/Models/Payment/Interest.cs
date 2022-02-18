using Asaas.Api.Dotnet.Models.Requests;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Payment
{
    public class Interest : RequestParams
    {
        [BodyParam("value")]
        [JsonProperty("value")]
        public decimal Value { get; set; }
    }
}