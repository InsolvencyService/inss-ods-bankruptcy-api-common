using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class IncomeFromLodgerValidator : AbstractValidator<IIncomeFromLodger>
    {
        public IncomeFromLodgerValidator()
        {
            RuleFor(x => x.IncomeAmount)
            .NotEmpty().WithLocalizedMessage(() => IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_Mandatory)
            .GreaterThan(0)
            .WithLocalizedMessage(() => IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_PositiveValueOnly)
            .LessThan(decimal.MaxValue)
            .WithLocalizedMessage(() => IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_EnterLessValue)
            .SetValidator(new ScalePrecisionValidator(2, 99,
            () => IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_Scale));

            RuleFor(x => x.IncomeAmount)
                .Must(x => false)
                .When(x => CheckAmountFieldInputType(x.IncomeAmount.ToString()) == false && !string.IsNullOrEmpty(x.IncomeAmount.ToString()))
                .WithLocalizedMessage(() => IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_NumberDecimalOnly);
        }

        private bool CheckAmountFieldInputType(string amount)
        {
            decimal outValue;
            if (decimal.TryParse(amount, out outValue) == false)
            {
                return false;
            }
            return true;
        }
    }
}