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
    public class OtherAssetsItemValidator : AbstractValidator<IOtherAssetsItem>
    {
        public OtherAssetsItemValidator()
        {
            RuleFor(x => x.Amount)
                .NotEmpty()
                .WithLocalizedMessage(() => ItemsResources.OtherAssets_Items_Amount_Error_Required)
                .When(x => !String.IsNullOrWhiteSpace(x.Description));

            RuleFor(x => x.Amount)
                .Must(x => x > 0)
                .WithLocalizedMessage(() => ItemsResources.OtherAssets_Items_Amount_Error_Minimum)
                .When(x => x.Amount != null);

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithLocalizedMessage(() => ItemsResources.OtherAssets_Items_Description_Error_Required)
                .When(x => x.Amount != null);

            RuleFor(x => x.Description)
                .Must(x => x.Length <= 100)
                .WithLocalizedMessage(() => ItemsResources.OtherAssets_Items_Description_Error_MaxLength)
                .When(x => !String.IsNullOrWhiteSpace(x.Description));

        }
    }
}
