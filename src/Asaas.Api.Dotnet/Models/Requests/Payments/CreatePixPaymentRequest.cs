using Asaas.Api.Dotnet.Attributes;

namespace Asaas.Api.Dotnet.Models.Requests.Payments
{
    public record CreatePixPaymentRequest : RequestParams
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
    }
}