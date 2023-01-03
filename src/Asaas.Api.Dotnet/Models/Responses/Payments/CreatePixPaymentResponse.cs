using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Responses.Payments
{
    public class CreatePixPaymentResponse : DefaultResponse
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
        public object PaymentLink { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("netValue")]
        public double NetValue { get; set; }

        [JsonProperty("originalValue")]
        public object OriginalValue { get; set; }

        [JsonProperty("interestValue")]
        public object InterestValue { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("billingType")]
        public string BillingType { get; set; }

        [JsonProperty("confirmedDate")]
        public string ConfirmedDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("originalDueDate")]
        public string OriginalDueDate { get; set; }

        [JsonProperty("paymentDate")]
        public object PaymentDate { get; set; }

        [JsonProperty("clientPaymentDate")]
        public string ClientPaymentDate { get; set; }

        [JsonProperty("invoiceUrl")]
        public string InvoiceUrl { get; set; }

        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("externalReference")]
        public string ExternalReference { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("anticipated")]
        public bool Anticipated { get; set; }

        [JsonProperty("creditDate")]
        public object CreditDate { get; set; }

        [JsonProperty("estimatedCreditDate")]
        public string EstimatedCreditDate { get; set; }

        [JsonProperty("transactionReceiptUrl")]
        public string TransactionReceiptUrl { get; set; }

        [JsonProperty("nossoNumero")]
        public object NossoNumero { get; set; }

        [JsonProperty("bankSlipUrl")]
        public object BankSlipUrl { get; set; }

        [JsonProperty("lastInvoiceViewedDate")]
        public object LastInvoiceViewedDate { get; set; }

        [JsonProperty("lastBankSlipViewedDate")]
        public object LastBankSlipViewedDate { get; set; }

        [JsonProperty("postalService")]
        public bool PostalService { get; set; }
    }
}