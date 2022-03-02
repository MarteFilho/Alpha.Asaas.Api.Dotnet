using Asaas.Api.Dotnet.Attributes;

namespace Asaas.Api.Dotnet.Models.Requests.Clients
{
    public record SearchClientsRequest : RequestParams
    {
        [QueryParameter("name")]
        public string? Name { get; set; }
        [QueryParameter("email")]
        public string? Email { get; set; }
        [QueryParameter("cpfCnpj")]
        public string? CpfCnpj { get; set; }
        [QueryParameter("groupName")]
        public string? GroupName { get; set; }
        [QueryParameter("externalReference")]
        public string? ExternalReference { get; set; }
        [QueryParameter("offset")]
        public int? Offset { get; set; }
        [QueryParameter("limit")]
        public int? Limit { get; set; }
    }
}