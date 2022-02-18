using Asaas.Api.Dotnet.Models.Payment;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Requests.Payments
{
    public class CreateCreditCardInstallmentPaymentRequest : RequestParams
    {
        [BodyParam("customer")]
        [JsonProperty("customer")]
        public string Customer { get; set; } = null!;

        [BodyParam("billingType")]
        [JsonProperty("billingType")]
        public string BillingType { get; set; } = null!;

        [BodyParam("installmentCount")]
        [JsonProperty("installmentCount")]
        public int InstallmentCount { get; set; }

        [BodyParam("installmentValue")]
        [JsonProperty("installmentValue")]
        public int? InstallmentValue { get; set; }

        [BodyParam("totalValue")]
        [JsonProperty("totalValue")]
        public int TotalValue { get; set; }

        [BodyParam("dueDate")]
        [JsonProperty("dueDate")]
        public string DueDate { get; set; } = null!;

        [BodyParam("description")]
        [JsonProperty("description")]
        public string? Description { get; set; }

        [BodyParam("externalReference")]
        [JsonProperty("externalReference")]
        public string? ExternalReference { get; set; }

        [BodyParam("creditCard")]
        [JsonProperty("creditCard")]
        public CreditCard CreditCard { get; set; }

        [BodyParam("creditCardHolderInfo")]
        [JsonProperty("creditCardHolderInfo")]
        public CreditCardHolderInfo CreditCardHolderInfo { get; set; }

        [BodyParam("discount")]
        [JsonProperty("discount")]
        public Discount? Discount { get; set; }

        [BodyParam("fine")]
        [JsonProperty("fine")]
        public Fine? Fine { get; set; }

        [BodyParam("interest")]
        [JsonProperty("interest")]
        public Interest? Interest { get; set; }
    }
}