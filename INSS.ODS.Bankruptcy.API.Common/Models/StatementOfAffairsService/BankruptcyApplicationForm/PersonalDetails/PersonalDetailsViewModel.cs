using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.PersonalDetails
{
    public class PersonalDetailsViewModel
    {
        public PersonalDetailsViewModel()
        {

        }

        public YourDetailsViewModel YourDetails { get; set; }

        public List<OtherNamesViewModel> OtherNames { get; set; }

        public ContactDetailsViewModel ContactDetails { get; set; }

        public ResidencyDetailsViewModel ResidencyDetails { get; set; }

        public List<HouseholdResidentDetailsViewModel> HouseholdResidentDetails { get; set; }

        public List<PreviousAddressViewModel> PreviousAddresses { get; set; }

        public List<NonResidentDependantsViewModel> NonResidentDependants { get; set; }

        public bool? PersonalSectionComplete { get; set; }
    }
}
