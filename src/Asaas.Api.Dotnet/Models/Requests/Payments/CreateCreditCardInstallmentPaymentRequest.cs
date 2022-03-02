using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Models.Payment;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Requests.Payments
{
    public record CreateCreditCardInstallmentPaymentRequest : RequestParams
    {
        [BodyParameter("customer")]
        [JsonProperty("customer")]
        public string Customer { get; set; } = null!;

        [BodyParameter("billingType")]
        [JsonProperty("billingType")]
        public string BillingType { get; set; } = null!;

        [BodyParameter("installmentCount")]
        [JsonProperty("installmentCount")]
        public int InstallmentCount { get; set; }

        [BodyParameter("installmentValue")]
        [JsonProperty("installmentValue")]
        public int? InstallmentValue { get; set; }

        [BodyParameter("totalValue")]
        [JsonProperty("totalValue")]
        public double TotalValue { get; set; }

        [BodyParameter("dueDate")]
        [JsonProperty("dueDate")]
        public string DueDate { get; set; } = null!;

        [BodyParameter("description")]
        [JsonProperty("description")]
        public string? Description { get; set; }

        [BodyParameter("externalReference")]
        [JsonProperty("externalReference")]
        public string? ExternalReference { get; set; }

        [BodyParameter("creditCard")]
        [JsonProperty("creditCard")]
        public CreditCard CreditCard { get; set; }

        [BodyParameter("creditCardHolderInfo")]
        [JsonProperty("creditCardHolderInfo")]
        public CreditCardHolderInfo CreditCardHolderInfo { get; set; }

        [BodyParameter("discount")]
        [JsonProperty("discount")]
        public Discount? Discount { get; set; }

        [BodyParameter("fine")]
        [JsonProperty("fine")]
        public Fine? Fine { get; set; }

        [BodyParameter("interest")]
        [JsonProperty("interest")]
        public Interest? Interest { get; set; }
    }
}