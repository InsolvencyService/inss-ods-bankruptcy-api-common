using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class FirstNameAndLastNameValidator : CompositeValidator<IFirstNameLastNamePartial>
    {
        public FirstNameAndLastNameValidator() : this(false)
        {

        }
        public FirstNameAndLastNameValidator(bool forApplicant)
        {
            RegisterBaseValidator(new FirstNameValidator(forApplicant));
            RegisterBaseValidator(new LastNameValidator(forApplicant));
        }
    }
}