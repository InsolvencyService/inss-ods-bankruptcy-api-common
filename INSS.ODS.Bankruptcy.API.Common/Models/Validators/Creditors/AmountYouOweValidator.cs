using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors
{
    public class AmountYouOweValidator: AbstractValidator<IAmountYouOwe>
    {
        public AmountYouOweValidator()
        {
            RuleFor(x => x.Amount)
                .NotEmpty().WithLocalizedMessage(() => AmountYouOweResources.Creditors_AmountYouOwe_Amount_Error_Mandatory)
                .GreaterThan(0).WithLocalizedMessage(() => AmountYouOweResources.Creditors_AmountYouOwe_Amount_Error_MinValue)           
                .SetValidator(new ScalePrecisionValidator(2, 99,
                    () => AmountYouOweResources.Creditors_AmountYouOwe_Amount_Error_Scale));

            RuleFor(x => x.Reference)
                .Length(3, 70).WithLocalizedMessage(
                    () => AmountYouOweResources.Creditors_AmountYouOwe_Reference_Length)
                .When(x => !string.IsNullOrEmpty(x.Reference));

            RuleFor(x => x.ApproxDebtStartedDateRange)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => AmountYouOweResources.Creditors_AmountYouOwe_StartDate_Error_Mandatory)
                .NotEmpty()
                .WithLocalizedMessage(() => AmountYouOweResources.Creditors_AmountYouOwe_StartDate_Error_Mandatory);

            RuleFor(x => x.DebtType)
                .NotNull()
                .WithLocalizedMessage(() => AmountYouOweResources.Creditors_AmountYouOwe_DebtType_Error_Mandatory);

            RuleFor(x => x.DebtType)
                .Must(x => false)
                .When(x => x.DebtType == "Other")
                .Unless(x => !String.IsNullOrWhiteSpace(x.DebtTypeOther))
                .WithLocalizedMessage(() => AmountYouOweResources.Creditors_AmountYouOwe_DebtType_Error_Other_OtherText);

            RuleFor(x=>x.DebtType)
                .Must(x => false)
                .When(x => x.DebtType == "Other" && !String.IsNullOrWhiteSpace(x.DebtTypeOther))
                .Unless(x => x.DebtTypeOther!=null && x.DebtTypeOther.Length >= 3)
                .WithLocalizedMessage(() => AmountYouOweResources.Creditors_AmountYouOwe_DebtType_Error_Other_MinLength);

            RuleFor(x => x.DebtType)
                .Must(x => false)
                .When(x => x.DebtType == "Other" && !String.IsNullOrWhiteSpace(x.DebtTypeOther))
                .Unless( x=> x.DebtTypeOther != null && x.DebtTypeOther.Length <= 50)
                .WithLocalizedMessage(() => AmountYouOweResources.Creditors_AmountYouOwe_DebtType_Error_Other_MaxLength);

        }
    }
}
