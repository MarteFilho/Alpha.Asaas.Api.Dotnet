using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Models.Requests;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Invoices
{
    public record ScheduleInvoiceRequest : RequestParams
    {
        [BodyParameter("payment")]
        [JsonProperty("payment")]
        public string? Payment { get; set; }
        [BodyParameter("installment")]
        [JsonProperty("installment")]
        public string? Installment { get; set; }
        [BodyParameter("customer")]
        [JsonProperty("customer")]
        public string? Customer { get; set; }
        [BodyParameter("serviceDescription")]
        [JsonProperty("serviceDescription")]
        public string? ServiceDescription { get; set; }
        [BodyParameter("observations")]
        [JsonProperty("observations")]
        public string Observations { get; set; }
        [BodyParameter("value")]
        [JsonProperty("value")]
        public double Value { get; set; }
        [BodyParameter("deductions")]
        [JsonProperty("deductions")]
        public int Deductions { get; set; }
        [BodyParameter("effectiveDate")]
        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
        [BodyParameter("externalReference")]
        [JsonProperty("externalReference")]
        public string? ExternalReference { get; set; }
        [BodyParameter("taxes")]
        [JsonProperty("taxes")]
        public Taxes? Taxes { get; set; }
        [BodyParameter("municipalServiceId")]
        [JsonProperty("municipalServiceId")]
        public string? MunicipalServiceId { get; set; }
        [BodyParameter("municipalServiceCode")]
        [JsonProperty("municipalServiceCode")]
        public string? MunicipalServiceCode { get; set; }
        [BodyParameter("municipalServiceName")]
        [JsonProperty("municipalServiceName")]
        public string? MunicipalServiceName { get; set; }
    }

    public class Taxes
    {
        [BodyParameter("retainIss")]
        [JsonProperty("retainIss")]
        public bool RetainIss { get; set; }
        [BodyParameter("iss")]
        [JsonProperty("iss")]
        public double Iss { get; set; }
        [BodyParameter("cofins")]
        [JsonProperty("cofins")]
        public double Cofins { get; set; }
        [BodyParameter("csll")]
        [JsonProperty("csll")]
        public double Csll { get; set; }
        [BodyParameter("inss")]
        [JsonProperty("inss")]
        public double Inss { get; set; }
        [BodyParameter("ir")]
        [JsonProperty("ir")]
        public double Ir { get; set; }
        [BodyParameter("pis")]
        [JsonProperty("pis")]
        public double Pis { get; set; }
    }
}