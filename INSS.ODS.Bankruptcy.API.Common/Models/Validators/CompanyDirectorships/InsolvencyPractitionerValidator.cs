using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships
{
    public class InsolvencyPractitionerValidator : CompositeValidator<InsolvencyPractitioner>
    {
        public InsolvencyPractitionerValidator()
        {
            RegisterBaseValidator(new InsolvencyPractitionerInterfaceValidator());

            RuleFor(x => x.Address).SetValidator(new AddressValidator());
        }
    }
}