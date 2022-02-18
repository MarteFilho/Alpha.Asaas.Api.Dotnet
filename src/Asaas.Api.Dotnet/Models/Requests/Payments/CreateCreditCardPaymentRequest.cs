using Asaas.Api.Dotnet.Models.Payment;

namespace Asaas.Api.Dotnet.Models.Requests.Payments
{
    public class CreateCreditCardPaymentRequest : RequestParams
    {
        [BodyParam("customer")]
        public string Customer { get; set; }

        [BodyParam("billingType")]
        public string BillingType { get; set; }

        [BodyParam("dueDate")]
        public string DueDate { get; set; }

        [BodyParam("value")]
        public double Value { get; set; }

        [BodyParam("description")]
        public string Description { get; set; }

        [BodyParam("externalReference")]
        public string ExternalReference { get; set; }

        [BodyParam("creditCard")]
        public CreditCard CreditCard { get; set; }

        [BodyParam("creditCardHolderInfo")]
        public CreditCardHolderInfo CreditCardHolderInfo { get; set; }

        [BodyParam("creditCardToken")]
        public string? CreditCardToken { get; set; }
    }
}