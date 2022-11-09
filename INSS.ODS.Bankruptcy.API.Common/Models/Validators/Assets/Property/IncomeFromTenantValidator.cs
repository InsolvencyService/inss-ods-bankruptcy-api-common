using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class IncomeFromTenantValidator : AbstractValidator<IIncomeFromTenant>
    {
        public IncomeFromTenantValidator()
        {
            RuleFor(x => x.IncomeAmount)
             .NotEmpty().WithLocalizedMessage(() => IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_Mandatory)
             .GreaterThan(0)
             .WithLocalizedMessage(() => IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_PositiveValueOnly)
             .LessThan(decimal.MaxValue)
             .WithLocalizedMessage(() => IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_EnterLessValue)
             .SetValidator(new ScalePrecisionValidator(2, 99,
             () => IncomeFromTenantResources.Property_IncomeFromTenant_Amount_Error_Scale));

            RuleFor(x => x.ManagingAgent)
           .NotEmpty()
           .WithLocalizedMessage(() => IncomeFromTenantResources.Property_IncomeFromTenant_ManagingAgent_Error_Mandatory);

        }
    }
}