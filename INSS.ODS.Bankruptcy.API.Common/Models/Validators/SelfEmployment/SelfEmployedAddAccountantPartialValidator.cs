using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class SelfEmployedAddAccountantPartialValidator : AbstractValidator<ISelfEmployedAddAccountantPartial>
    {

        public SelfEmployedAddAccountantPartialValidator()
        {

            RuleFor(x => x.AccountantName)
                .NotEmpty().WithMessage(AccountantSummaryResources.AccountantSummary_AccountantName_Required )
                .Length(3, 30).WithMessage(AccountantSummaryResources.AccountantSummary_AccountantName_Length );

       

        }

       
    }
}

