using Asaas.Api.Dotnet.Models.Responses.Payments;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Responses.Subscriptions
{
    public class CreateCreditCardSubscriptionResponse : DefaultResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("paymentLink")]
        public string PaymentLink { get; set; }

        [JsonProperty("billingType")]
        public string BillingType { get; set; }

        [JsonProperty("cycle")]
        public string Cycle { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("nextDueDate")]
        public string NextDueDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("creditCard")]
        public CreditCard CreditCard { get; set; }
    }
}