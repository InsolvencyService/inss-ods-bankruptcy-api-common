namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.PersonalDetails
{
    public class HouseholdResidentDetailsViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AgeGroup { get; set; }

        public string Relationship { get; set; }

        public bool IsFinanciallyDependent { get; set; }    
    }
}