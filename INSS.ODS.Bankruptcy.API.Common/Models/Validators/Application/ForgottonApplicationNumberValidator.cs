using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class ForgottonApplicationNumberValidator : CompositeValidator<IForgottenApplicationNumber>
    {
        public ForgottonApplicationNumberValidator()
        {

            RegisterBaseValidator(new FirstNameValidator(true));
            RegisterBaseValidator(new LastNameValidator(true));

         

            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage(ForgottenApplicationNumberResources.Application_ForgottenApplicationNumber_Email_Error_Format)
                .When(x => !string.IsNullOrEmpty(x.Email));

          

        }
    }
}