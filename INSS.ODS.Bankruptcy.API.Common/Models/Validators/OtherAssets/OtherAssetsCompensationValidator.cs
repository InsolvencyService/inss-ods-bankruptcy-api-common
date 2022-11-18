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
    public class OtherAssetsCompensationValidator : AbstractValidator<IOtherAssetsCompensation>
    {
        public OtherAssetsCompensationValidator()
        {
            RuleFor(x => x.Amount)
                .NotEmpty()
                .WithMessage(CompensationsResources.OtherAssets_Compensations_Amount_Error_Required)
                .When(x => !String.IsNullOrWhiteSpace(x.Description));

            RuleFor(x => x.Amount)
                .Must(x=> x > 0)
                .WithMessage(CompensationsResources.OtherAssets_Compensations_Amount_Error_Minimum)
                .When(x => x.Amount != null);

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage(CompensationsResources.OtherAssets_Compensations_Description_Error_Required)
                .When(x => x.Amount!=null);

            RuleFor(x => x.Description)
                .Must(x=> x.Length <= 100)
                .WithMessage(CompensationsResources.OtherAssets_Compensations_Description_Error_MaxLength)
                .When(x => !String.IsNullOrWhiteSpace(x.Description));
        }
    }
}
