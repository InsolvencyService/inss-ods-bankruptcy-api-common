using System;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors
{
    public class ReasonForDebtValidator: AbstractValidator<IReasonForDebt>
    {
        public ReasonForDebtValidator()
        {
            //RuleFor(x=> x.ReasonForDebt_FieldsetStart)
            //    .Must(x => false)
            //    .When(x => !x.AnySelected)
            //    .WithLocalizedMessage(() => ReasonForDebtResources.Creditors_ReasonForDebt_Reason_Error_Mandatory);

            //RuleFor(x => x.ReasonForDebt_FieldsetStart)
            //    .Must(x => false)
            //    .When(x => x.Other)
            //    .Unless(x => !String.IsNullOrWhiteSpace(x.Other_Text))
            //    .WithLocalizedMessage(() => ReasonForDebtResources.Creditors_ReasonForDebt_Reason_Error_OtherText);


            RuleFor(x=> x.ReasonsForDebt)
                .Must(x=> false)
                .When(x => !x.AnySelected)
                .WithLocalizedMessage(() => ReasonForDebtResources.Creditors_ReasonForDebt_Reason_Error_Mandatory);

            RuleFor(x => x.ReasonsForDebt)
                .Must(x => false)
                .When(x => x.Other)
                .Unless(x => !String.IsNullOrWhiteSpace(x.Other_Text))
                .WithLocalizedMessage(() => ReasonForDebtResources.Creditors_ReasonForDebt_Reason_Error_Mandatory);

            RuleFor(x => x.ReasonsForDebt)
                .Must(x => false)
                .When(x => !String.IsNullOrWhiteSpace(x.Other_Text))
                .Unless(x => x.Other)
                .WithLocalizedMessage(() => ReasonForDebtResources.Creditors_ReasonForDebt_Reason_Error_OtherText);

           RuleFor(x => x.ReasonsForDebt)
                .Must(x => false)
                .When(x => !String.IsNullOrWhiteSpace(x.Other_Text))
                .Unless(x => x.Other_Text != null && x.Other_Text.Length >= 3)
                .WithLocalizedMessage(() => ReasonForDebtResources.Creditors_ReasonForDebt_Reason_Error_Other_MinLength);
                

            RuleFor(x => x.ReasonsForDebt)
                .Must(x => false)
                .When(x => !String.IsNullOrWhiteSpace(x.Other_Text))
                .Unless(x => x.Other_Text != null && x.Other_Text.Length <= 50)
                .WithLocalizedMessage(() => ReasonForDebtResources.Creditors_ReasonForDebt_Reason_Error_Other_MaxLength);

        }
    }
}
