namespace INSS.ODS.Bankruptcy.API.Common.Models.BankAccountService.Interfaces;

public interface ISortCodeLookupResponse
{
    string BankBIC { get; set; }

    string BranchBIC { get; set; }

    string BankName { get; set; }
    
    string BankOfficeTitle { get; set; }
    
    string BranchName { get; set; }
    
    string OfficeTitle { get; set; }
    
    string ContactAddress1 { get; set; }
    
    string ContactAddress2 { get; set; }
    
    string ContactAddress3 { get; set; }
    
    string ContactAddress4 { get; set; }
    
    string ContactAddressCity { get; set; }
    
    string ContactAddressCounty { get; set; }
    
    string ContactAddressPostCode { get; set; }
    
    string ContactAddressPostCountry { get; set; }
    
    string ContactPhoneNumber { get; set; }
    
    string SortCode { get; set; }
}
