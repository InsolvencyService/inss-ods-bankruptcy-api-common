using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class OtherPensionValidator : AbstractValidator<IOtherPension>
    {
        public OtherPensionValidator()
        {
            RuleFor(r => r.Type)
                   .NotEmpty()
                   .WithMessage(PensionResources.Income_Pension_OtherPension_Type_Error_Empty)
                   .When(r => r.Value.HasValue);

            RuleFor(r => r.Value)
                .GreaterThanOrEqualTo(0)
                .WithMessage(PensionResources.Income_Pension_OtherPension_Value_Error_Negative)
                .When(r => r.Value.HasValue);

            RuleFor(r => r.Value)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(PensionResources.Income_Pension_OtherPension_Value_Error_Empty)
                //.GreaterThanOrEqualTo(0)
                //.WithMessage(
                    //() => PensionResources.Income_Pension_OtherPension_Value_Error_Negative)
                //.SetValidator(new ScalePrecisionValidator(2, 99, () => PensionResources.Income_Pension_OtherPension_Value_Error_Scale))
                .When(r => !string.IsNullOrEmpty(r.Type));
        }
    }
}