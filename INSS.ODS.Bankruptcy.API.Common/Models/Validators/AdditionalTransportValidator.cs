using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class AdditionalTransportValidator : AbstractValidator<IAdditionalTransport>
    {
        
        public AdditionalTransportValidator()
        {

            RuleFor(r => r.Additional_Transport_Text)
                  .NotEmpty()
                  .WithMessage(TransportResources.Expenses_Transport_Additonal_Transport_Text_Error)
                  .When(r => r.Additional_Transport_Value.HasValue);

            RuleFor(r => r.Additional_Transport_Value)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(TransportResources.Expenses_Transport_Additional_Transport_Value_Required)
                .GreaterThanOrEqualTo(0)
                .WithMessage(TransportResources.Expenses_Transport_Additional_Transport_Value_Postive_Error)
                .ScalePrecision(2, 99).WithMessage(TransportResources.Expenses_Transport_Additional_Transport_Value_Postive_Error)
                .When(r => !string.IsNullOrEmpty(r.Additional_Transport_Text));
        }
    }
}
