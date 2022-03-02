using Asaas.Api.Dotnet.Attributes;

namespace Asaas.Api.Dotnet.Models.Requests.Clients
{
    public record CreateClientRequest : RequestParams
    {
        [BodyParameter("name")]
        public string Name { get; set; }

        [BodyParameter("email")]
        public string Email { get; set; }

        [BodyParameter("phone")]
        public string Phone { get; set; }

        [BodyParameter("mobilePhone")]
        public string MobilePhone { get; set; }

        [BodyParameter("cpfCnpj")]
        public string CpfCnpj { get; set; }

        [BodyParameter("postalCode")]
        public string PostalCode { get; set; }

        [BodyParameter("address")]
        public string Address { get; set; }

        [BodyParameter("addressNumber")]
        public string AddressNumber { get; set; }

        [BodyParameter("complement")]
        public string Complement { get; set; }

        [BodyParameter("province")]
        public string Province { get; set; }

        [BodyParameter("externalReference")]
        public string ExternalReference { get; set; }

        [BodyParameter("notificationDisabled")]
        public bool NotificationDisabled { get; set; }

        [BodyParameter("additionalEmails")]
        public string AdditionalEmails { get; set; }

        [BodyParameter("municipalInscription")]
        public string MunicipalInscription { get; set; }

        [BodyParameter("stateInscription")]
        public string StateInscription { get; set; }

        [BodyParameter("observations")]
        public string Observations { get; set; }
    }
}