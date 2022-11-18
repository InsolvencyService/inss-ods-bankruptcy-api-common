using System;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors
{
    public class DebtDetailValidator : AbstractValidator<IDebtDetail>
    {
        public DebtDetailValidator()
        {

            RuleFor(x => x.ReasonsForDebt)
             .Must(x => false)
             .When(x => !x.AnySelected && x.RequiresReason)
             .WithMessage(DebtDetailsResources.Creditors_DebtDetails_Reason_Error_Mandatory);

            RuleFor(x => x.ReasonsForDebt)
                .Must(x => false)
                .When(x => x.Other && x.RequiresReason)
                .Unless(x => !String.IsNullOrWhiteSpace(x.Other_Text))
                .WithMessage(DebtDetailsResources.Creditors_DebtDetails_Reason_OtherText_NoOther);
            

            RuleFor(x => x.ReasonsForDebt)
                .Must(x => false)
                .When(x => !String.IsNullOrWhiteSpace(x.Other_Text) && x.RequiresReason)
                .Unless(x => x.Other)
                .WithMessage(DebtDetailsResources.Creditors_DebtDetails_Reason_Error_OtherText);




            RuleFor(x => x.ApproxDebtStartedDateRange)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotNull()
            .WithMessage(DebtDetailsResources.Creditors_DebtDetails_StartDate_Error_Mandatory)
            .NotEmpty()
            .WithMessage(DebtDetailsResources.Creditors_DebtDetails_StartDate_Error_Mandatory);


            RuleFor(r => r.SeizedOrSoldAssets)
          .NotNull()
          .WithMessage(DebtDetailsResources.Creditors_DebtDetails_SeizedOrSoldAssets_Required);

            RuleFor(r => r.AttachmentOfEarnings)
          .NotNull()
          .WithMessage(DebtDetailsResources.Creditors_DebtDetails_AttachmentOfEarnings_Required);



            RuleFor(x => x.ValidationHook)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .Must(OnlyOneRecentAction)
               .WithMessage(DebtDetailsResources.Creditors_DebtDetails_Recent_Action_Error);
        }

        private bool OnlyOneRecentAction(IDebtDetail instance, bool ValidationHook)
        {
            if (instance.SeizedOrSoldAssets.HasValue && instance.SeizedOrSoldAssets.Value==true && instance.AttachmentOfEarnings.HasValue && instance.AttachmentOfEarnings.Value==true)
            {
                return false;
            }
            return true;

        }

    }
}








