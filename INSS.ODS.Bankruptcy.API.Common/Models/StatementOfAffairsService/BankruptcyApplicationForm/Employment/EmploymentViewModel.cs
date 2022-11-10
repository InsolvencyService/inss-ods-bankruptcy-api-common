using System.Collections.Generic;
using System.Security.AccessControl;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.Employers;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.NonLimitedBusinesses;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.SelfEmployments;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment
{
    public class EmploymentViewModel
    {
        public bool? HasApplicantBeenDirectorInLast12Months { get; set; }

        public List<CompanyDirectorshipViewModel> CompanyDirectorships { get; set; }

        public bool? HasApplicantBeenSelfEmployedInLast3Years { get; set; }

        public List<SelfEmploymentViewModel> SelfEmployments { get; set; }

        public bool? HasApplicantBeenPartnerInNonLimitedBusinessInLast3Years { get; set; }

        public List<NonLimitedBusinessViewModel> NonLimitedBusinesses { get; set; }

        public bool? HasApplicantBeenEmployedInLast12Months { get; set; }

        public List<EmployerViewModel> Employers { get; set; }

        public string EmploymentStatus { get; set; }
    }
}
