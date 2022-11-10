using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.PersonalDetails
{
    public class LandlordDetailsViewModel
    {
        public LandlordDetailsViewModel()
        {
            Address = new AddressViewModel();
        }

        public string LandlordName { get; set; }

        public AddressViewModel Address { get; set; }
    }
}