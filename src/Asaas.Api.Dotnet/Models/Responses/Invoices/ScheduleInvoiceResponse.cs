using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Models.Responses;
using Newtonsoft.Json;

namespace Asaas.Api.Dotnet.Models.Invoices
{
    public class ScheduleInvoiceResponse : DefaultResponse
    {
        [BodyParameter("object")]
        [JsonProperty("object")]
        public string Object { get; set; }
        [BodyParameter("id")]
        [JsonProperty("id")]
        public string Id { get; set; }
        [BodyParameter("status")]
        [JsonProperty("status")]
        public string Status { get; set; }
        [BodyParameter("customer")]
        [JsonProperty("customer")]
        public string Customer { get; set; }
        [BodyParameter("type")]
        [JsonProperty("type")]
        public string Type { get; set; }
        [BodyParameter("statusDescription")]
        [JsonProperty("statusDescription")]
        public object StatusDescription { get; set; }
        [BodyParameter("serviceDescription")]
        [JsonProperty("serviceDescription")]
        public string ServiceDescription { get; set; }
        [BodyParameter("pdfUrl")]
        [JsonProperty("pdfUrl")]
        public string PdfUrl { get; set; }
        [BodyParameter("xmlUrl")]
        [JsonProperty("xmlUrl")]
        public string XmlUrl { get; set; }
        [BodyParameter("rpsSerie")]
        [JsonProperty("rpsSerie")]
        public string RpsSerie { get; set; }
        [BodyParameter("rpsNumber")]
        [JsonProperty("rpsNumber")]
        public string RpsNumber { get; set; }
        [BodyParameter("number")]
        [JsonProperty("number")]
        public string Number { get; set; }
        [BodyParameter("validationCode")]
        [JsonProperty("validationCode")]
        public string ValidationCode { get; set; }
        [BodyParameter("value")]
        [JsonProperty("value")]
        public string Value { get; set; }
        [BodyParameter("deductions")]
        [JsonProperty("deductions")]
        public int Deductions { get; set; }
        [BodyParameter("effectiveDate")]
        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
        [BodyParameter("observations")]
        [JsonProperty("observations")]
        public string Observations { get; set; }
        [BodyParameter("estimatedTaxesDescription")]
        [JsonProperty("estimatedTaxesDescription")]
        public string EstimatedTaxesDescription { get; set; }
        [BodyParameter("payment")]
        [JsonProperty("payment")]
        public string Payment { get; set; }
        [BodyParameter("installment")]
        [JsonProperty("installment")]
        public string Installment { get; set; }
        [BodyParameter("externalReference")]
        [JsonProperty("externalReference")]
        public string ExternalReference { get; set; }
        [BodyParameter("taxes")]
        [JsonProperty("taxes")]
        public Taxes Taxes { get; set; }
        [BodyParameter("municipalServiceId")]
        [JsonProperty("municipalServiceId")]
        public string MunicipalServiceId { get; set; }
        [BodyParameter("municipalServiceCode")]
        [JsonProperty("municipalServiceCode")]
        public string MunicipalServiceCode { get; set; }
        [BodyParameter("municipalServiceName")]

        [JsonProperty("municipalServiceName")]
        public string MunicipalServiceName { get; set; }
    }
}