using INSS.ODS.Bankruptcy.API.Common.Models.CreditorsService.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CreditorsService.Dto
{
    public class CreditorSearchResultDto: ICreditorSearchResult
    {
        public string SourceRef { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}