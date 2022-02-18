namespace Asaas.Api.Dotnet.Models.Requests.Clients
{
    public class SearchClientsRequest : RequestParams
    {
        [QueryParam("name")]
        public string? Name { get; set; }
        [QueryParam("email")]
        public string? Email { get; set; }
        [QueryParam("cpfCnpj")]
        public string? CpfCnpj { get; set; }
        [QueryParam("groupName")]
        public string? GroupName { get; set; }
        [QueryParam("externalReference")]
        public string? ExternalReference { get; set; }
        [QueryParam("offset")]
        public int? Offset { get; set; }
        [QueryParam("limit")]
        public int? Limit { get; set; }
    }
}