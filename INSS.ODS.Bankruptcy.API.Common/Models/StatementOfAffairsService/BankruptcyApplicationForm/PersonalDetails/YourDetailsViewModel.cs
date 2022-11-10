using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.PersonalDetails
{
    public class YourDetailsViewModel
    {
        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleNames { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string NationalInsuranceNumber { get; set; }

        public string CurrentRelationship { get; set; }
    }
}