using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.PersonalDetails
{
    public class NonResidentDependantsViewModel
    {
        public NonResidentDependantsViewModel()
        {

        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public string Relationship { get; set; }

        public AddressViewModel Address { get; set; }

    }
}