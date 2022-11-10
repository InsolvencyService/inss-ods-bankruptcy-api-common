using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships
{
    public class InsolvencyPractitionerInterfaceValidator : CompositeValidator<IInsolvencyPractitioner>
    {
        public InsolvencyPractitionerInterfaceValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());
        }
    }
}