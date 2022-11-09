using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;
using FluentValidation.Validators;



namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class OtherIncomeValidator : AbstractValidator<IOtherIncomeDetails>
    {
        public OtherIncomeValidator()
        {
            
                RuleFor(r => r.Amount)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotNull()
               .WithLocalizedMessage(
                   () => OtherIncomeResources.Income_OtherIncome_Amount_Error_RequiredIfSourceIsEntered)
               .GreaterThanOrEqualTo(0)
               .WithLocalizedMessage(
                   () => OtherIncomeResources.Income_OtherIncome_Amount_Error_ExpectedPositiveAndNumericValue)
               .SetValidator(new ScalePrecisionValidator(2, 99, () => OtherIncomeResources.Income_OtherIncome_Amount_Error_DecimalPlaces))
               .When(r => !string.IsNullOrEmpty(r.Source));

                RuleFor(r => r.Source)
                   .NotEmpty()
                   .WithLocalizedMessage(
                       () => OtherIncomeResources.Income_OtherIncome_Source_Error_RequiredIfAmountIsEntered)
                   .When(r => r.Amount.HasValue);

        }         
    }
}