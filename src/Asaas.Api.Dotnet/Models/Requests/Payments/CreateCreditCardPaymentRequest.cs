using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Models.Payment;

namespace Asaas.Api.Dotnet.Models.Requests.Payments
{
    public record CreateCreditCardPaymentRequest : RequestParams
    {
        [BodyParameter("customer")]
        public string Customer { get; set; }

        [BodyParameter("billingType")]
        public string BillingType { get; set; }

        [BodyParameter("dueDate")]
        public string DueDate { get; set; }

        [BodyParameter("value")]
        public double Value { get; set; }

        [BodyParameter("description")]
        public string Description { get; set; }

        [BodyParameter("externalReference")]
        public string ExternalReference { get; set; }

        [BodyParameter("creditCard")]
        public CreditCard CreditCard { get; set; }

        [BodyParameter("creditCardHolderInfo")]
        public CreditCardHolderInfo CreditCardHolderInfo { get; set; }

        [BodyParameter("creditCardToken")]
        public string? CreditCardToken { get; set; }
    }
}