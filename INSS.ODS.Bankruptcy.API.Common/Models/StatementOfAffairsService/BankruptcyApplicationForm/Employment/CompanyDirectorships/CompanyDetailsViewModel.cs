namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.CompanyDirectorships
{
    public class CompanyDetailsViewModel
    {
        public string CompanyName { get; set; }

        public bool? IsCompanyRegisteredInTheUK { get; set; }

        public string CompanyRegistrationCountry { get; set; }

        public string CompanyRegistrationNumber { get; set; }

        public bool? IsCompanySubjectToInsolvencyProceedings { get; set; }

        public bool? IsApplicantActiveDirectorInCompany { get; set; }
    }
}