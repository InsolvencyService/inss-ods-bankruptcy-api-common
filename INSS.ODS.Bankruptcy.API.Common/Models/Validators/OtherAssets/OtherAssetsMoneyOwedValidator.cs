using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Resources.OtherAssets;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.OtherAssets
{
    public class OtherAssetsMoneyOwedValidator : AbstractValidator<IOtherAssetsMoneyOwed>
    {
        public OtherAssetsMoneyOwedValidator()
        {
            RuleFor(x => x.Amount)
                .NotEmpty()
                .WithLocalizedMessage(() => MoneyOwedResources.OtherAssets_MoneyOwed_Amount_Error_Required)
                .When(x => !String.IsNullOrWhiteSpace(x.Reason) || !string.IsNullOrWhiteSpace(x.WhoOwesYou));

            RuleFor(x => x.Amount)
                .Must(x => x > 0)
                .WithLocalizedMessage(() => MoneyOwedResources.OtherAssets_MoneyOwed_Amount_Error_Minimum)
                .When(x => x.Amount != null);

            RuleFor(x => x.Reason)
                .NotEmpty()
                .WithLocalizedMessage(() => MoneyOwedResources.OtherAssets_MoneyOwed_Reason_Error_Required)
                .When(x => x.Amount != null || !String.IsNullOrWhiteSpace(x.WhoOwesYou));

            RuleFor(x => x.WhoOwesYou)
                .NotEmpty()
                .WithLocalizedMessage(() => MoneyOwedResources.OtherAssets_MoneyOwed_WhoOwesYou_Error_Required)
                .When(x => x.Amount != null || !String.IsNullOrWhiteSpace(x.Reason));

            RuleFor(x => x.Reason)
                .Must(x => x.Length <= 100)
                .WithLocalizedMessage(() => MoneyOwedResources.OtherAssets_MoneyOwed_Reason_Error_MaxLength)
                .When(x => !String.IsNullOrWhiteSpace(x.Reason));

            RuleFor(x => x.WhoOwesYou)
                .Must(x => x.Length <= 100)
                .WithLocalizedMessage(() => MoneyOwedResources.OtherAssets_MoneyOwed_WhoOwesYou_Error_MaxLength)
                .When(x => !String.IsNullOrWhiteSpace(x.WhoOwesYou));

        }
    }
}
