using INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships
{
    public class CompanyDirectorshipValidator : CompositeValidator<CompanyDirectorship>
    {
        public CompanyDirectorshipValidator()
        {
            RegisterBaseValidator(new LimitedCompanyDetailsInterfaceValidator());
            RegisterBaseValidator(new LimitedCompanyNameInterfaceValidator());
        }
    }
}