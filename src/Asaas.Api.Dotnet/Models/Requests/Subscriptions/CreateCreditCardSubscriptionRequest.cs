using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Models.Payment;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Requests.Subscriptions
{
    public record CreateCreditCardSubscriptionRequest : RequestParams
    {
        [BodyParameter("customer")]
        public string Customer { get; set; }

        [BodyParameter("billingType")]
        public string BillingType { get; set; }

        [BodyParameter("nextDueDate")]
        public string NextDueDate { get; set; }

        [BodyParameter("value")]
        public double Value { get; set; }

        [BodyParameter("cycle")]
        public string Cycle { get; set; }

        [BodyParameter("description")]
        public string Description { get; set; }

        [BodyParameter("creditCard")]
        public CreditCard CreditCard { get; set; }

        [BodyParameter("creditCardHolderInfo")]
        public CreditCardHolderInfo CreditCardHolderInfo { get; set; }

        [BodyParameter("creditCardToken")]
        public string CreditCardToken { get; set; }
    }
}