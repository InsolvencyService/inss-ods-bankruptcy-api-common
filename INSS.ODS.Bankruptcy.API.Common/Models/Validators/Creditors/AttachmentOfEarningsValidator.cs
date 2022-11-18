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
     .NotEmpty().WithMessage(AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_AmountTaken_Required)
     .GreaterThan(0).WithMessage(AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_AmountTaken_Min)
     .ScalePrecision(2, 99).WithMessage(AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_AmountTaken_Scale);

            RuleFor(x => x.HowOftenTaken)
.Cascade(CascadeMode.StopOnFirstFailure)
.NotNull()
.WithMessage(AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_HowOften_Required)
.NotEmpty()
.WithMessage(AttachmentOfEarningsResources.Creditors_AttachmentOfEarnings_HowOften_Required);
        }
    }
}
