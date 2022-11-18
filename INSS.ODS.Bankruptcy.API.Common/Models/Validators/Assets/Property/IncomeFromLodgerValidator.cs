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
            .NotEmpty().WithMessage(IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_Mandatory)
            .GreaterThan(0)
            .WithMessage(IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_PositiveValueOnly)
            .LessThan(decimal.MaxValue)
            .WithMessage(IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_EnterLessValue)
            .ScalePrecision(2, 99).WithMessage(IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_Scale);

            RuleFor(x => x.IncomeAmount)
                .Must(x => false)
                .When(x => CheckAmountFieldInputType(x.IncomeAmount.ToString()) == false && !string.IsNullOrEmpty(x.IncomeAmount.ToString()))
                .WithMessage(IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_NumberDecimalOnly);
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