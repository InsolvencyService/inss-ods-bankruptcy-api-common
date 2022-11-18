using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class ForgottonApplicationNumberPostalValidator : CompositeValidator<IForgottenApplicationNumberPostal>
    {
        public ForgottonApplicationNumberPostalValidator()
        {

            RegisterBaseValidator(new FirstNameValidator(true));
            RegisterBaseValidator(new LastNameValidator(true));

            RuleFor(r => r.AddressLine1)
            .NotEmpty()
            .WithMessage(ForgottenApplicationNumberPostalResources.Application_ForgottenApplicationNumberPostal_AddressLine1_Error_Empty );

            RuleFor(r => r.PostCode)
              .NotEmpty()
              .WithMessage(ForgottenApplicationNumberPostalResources.Application_ForgottenApplicationNumberPostal_Postcode_Error_Empty);


        }
    }
}