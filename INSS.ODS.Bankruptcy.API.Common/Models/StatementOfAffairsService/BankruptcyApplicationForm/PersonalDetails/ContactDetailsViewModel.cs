using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.PersonalDetails
{
    public class ContactDetailsViewModel
    {
        public string EmailAddress { get; set; }

        public string MobileNumber { get; set; }

        public string TelephoneNumber { get; set; }

        public AddressViewModel Address { get; set; }
    }
}