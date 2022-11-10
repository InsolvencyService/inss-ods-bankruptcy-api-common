using System;
using INSS.ODS.Bankruptcy.API.Common.Models.BankAccountService.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.BankAccountService
{
    public class SortCodeLookupResponse : ISortCodeLookupResponse
    {
        public string BankBIC { get; set; }
        
        public string BranchBIC { get; set; }
        
        public string BankName { get; set; }
        
        public string BankOfficeTitle { get; set; }
        
        public string BranchName { get; set; }
        
        public string OfficeTitle { get; set; }
        
        public string ContactAddress1 { get; set; }
        
        public string ContactAddress2 { get; set; }
        
        public string ContactAddress3 { get; set; }
        
        public string ContactAddress4 { get; set; }
        
        public string ContactAddressCity { get; set; }
        
        public string ContactAddressCounty { get; set; }
        
        public string ContactAddressPostCode { get; set; }
        
        public string ContactAddressPostCountry { get; set; }
        
        public string ContactPhoneNumber { get; set; }
        
        public string SortCode { get; set; }
    }

}