using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.CompanyDirectorships
{
    public class InsolvencyPractitionerDetailsViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AddressViewModel Address { get; set; }
    }
}