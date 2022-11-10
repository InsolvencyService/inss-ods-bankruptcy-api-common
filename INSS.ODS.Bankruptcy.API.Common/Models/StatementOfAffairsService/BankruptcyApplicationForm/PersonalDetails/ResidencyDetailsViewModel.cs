using System;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.PersonalDetails
{
    public class ResidencyDetailsViewModel
    {
        public ResidencyDetailsViewModel()
        {

        }

        //public string CurrentAddress { get; set; }
        public AddressViewModel CurrentAddress { get; set; }

        public DateTime? DateMovedIn { get; set; }

        public string PropertyOwnership { get; set; }

        public bool IsPropertyRented { get; set; }

        public LandlordDetailsViewModel LandlordDetails { get; set; }
    }
}