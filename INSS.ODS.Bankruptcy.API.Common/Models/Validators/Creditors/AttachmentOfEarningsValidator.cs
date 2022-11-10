using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;
using FluentValidation.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors
{
    public class AttachmentOfEarningsValidator : AbstractValidator<IAttachmentOfEarnings>
    {
        public AttachmentOfEarningsValidator()
        {
            RuleFor(x => x.AmountTaken)
     .NotEmpty().WithLocalizedMessage(() => AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_AmountTaken_Required)
     .GreaterThan(0).WithLocalizedMessage(() => AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_AmountTaken_Min)
     .SetValidator(new ScalePrecisionValidator(2, 99,
         () => AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_AmountTaken_Scale));

            RuleFor(x => x.HowOftenTaken)
.Cascade(CascadeMode.StopOnFirstFailure)
.NotNull()
.WithLocalizedMessage(() => AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_HowOften_Required)
.NotEmpty()
.WithLocalizedMessage(() => AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_HowOften_Required);
        }
    }
}
