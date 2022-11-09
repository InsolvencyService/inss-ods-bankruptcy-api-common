using System;
using System.Text;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.PersonalDetails
{
    public class PreviousAddressViewModel : AddressViewModel
    {
        public DateTime? MovedInDate { get; set; }

        public DateTime? MovedOutDate { get; set; }
    }
}