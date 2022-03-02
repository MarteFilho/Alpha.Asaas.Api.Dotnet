using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Models.Requests;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Payment
{
    public record Discount : RequestParams
    {
        [BodyParameter("value")]
        [JsonProperty("value")]
        public decimal Value { get; set; }

        [BodyParameter("dueDateLimitDays")]
        [JsonProperty("dueDateLimitDays")]
        public int DueDateLimitDays { get; set; }
    }
}