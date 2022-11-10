using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Resources.OtherAssets;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.OtherAssets
{
    public class OtherAssetsCashValidator : AbstractValidator<IOtherAssetsCash>
    {
        public OtherAssetsCashValidator()
        {
            RuleFor(x => x.Amount)
                .Must(x => x > 0)
                .When(x => x.Amount.HasValue)
                .WithLocalizedMessage(() => CashResources.OtherAssets_Cash_Amount_Error_Minimum);

            RuleFor(x => x.Amount).SetValidator(new CurrencyValidator());

        }
    }
}
