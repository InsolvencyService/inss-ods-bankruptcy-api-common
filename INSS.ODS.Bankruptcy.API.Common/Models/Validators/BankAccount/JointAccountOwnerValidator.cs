using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class JointAccountOwnerValidator : CompositeValidator<IJointAccountOwner>
    {
        public JointAccountOwnerValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());

        }
    }
}