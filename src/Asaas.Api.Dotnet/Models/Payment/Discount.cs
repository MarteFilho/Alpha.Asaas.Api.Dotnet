using Asaas.Api.Dotnet.Models.Requests;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Payment
{
    public class Discount : RequestParams
    {
        [BodyParam("value")]
        [JsonProperty("value")]
        public decimal Value { get; set; }

        [BodyParam("dueDateLimitDays")]
        [JsonProperty("dueDateLimitDays")]
        public int DueDateLimitDays { get; set; }
    }
}