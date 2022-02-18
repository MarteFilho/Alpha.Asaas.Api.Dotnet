namespace Asaas.Api.Dotnet.Models.Requests.Clients
{
    public class CreateClientRequest : RequestParams
    {
        [BodyParam("name")]
        public string Name { get; set; }

        [BodyParam("email")]
        public string Email { get; set; }

        [BodyParam("phone")]
        public string Phone { get; set; }

        [BodyParam("mobilePhone")]
        public string MobilePhone { get; set; }

        [BodyParam("cpfCnpj")]
        public string CpfCnpj { get; set; }

        [BodyParam("postalCode")]
        public string PostalCode { get; set; }

        [BodyParam("address")]
        public string Address { get; set; }

        [BodyParam("addressNumber")]
        public string AddressNumber { get; set; }

        [BodyParam("complement")]
        public string Complement { get; set; }

        [BodyParam("province")]
        public string Province { get; set; }

        [BodyParam("externalReference")]
        public string ExternalReference { get; set; }

        [BodyParam("notificationDisabled")]
        public bool NotificationDisabled { get; set; }

        [BodyParam("additionalEmails")]
        public string AdditionalEmails { get; set; }

        [BodyParam("municipalInscription")]
        public string MunicipalInscription { get; set; }

        [BodyParam("stateInscription")]
        public string StateInscription { get; set; }

        [BodyParam("observations")]
        public string Observations { get; set; }
    }
}