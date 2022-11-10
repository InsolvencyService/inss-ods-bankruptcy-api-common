using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PropertyDebtDetailsValidator : AbstractValidator<IPropertyDebtDetails>
    {
        public PropertyDebtDetailsValidator()
        {
            RuleFor(x => x.DebtStartDate)
                .NotEmpty().WithLocalizedMessage(() => PropertyDebtDetailsResources.Property_PropertyDebtDetails_DebtStartDate_Error_Required)
                .LessThanOrEqualTo(DateTime.Today)
                .WithLocalizedMessage(() => PropertyDebtDetailsResources.Property_PropertyDebtDetails_DebtStartDate_Error_FutureDateNotAllowed);

            RuleFor(x => x.DebtStartDate)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                 .WithLocalizedMessage(() => PropertyDebtDetailsResources.Property_PropertyDebtDetails_DebtStartDate_Error_MinDateRequirement)
                .When(x => x.DebtStartDate != DateTime.MinValue);
            
            RuleFor(x => x.ReferenceNumber)
            .Must(x => false)
            .When(x => (!string.IsNullOrWhiteSpace(x.ReferenceNumber)) &&
            (x.ReferenceNumber.Trim().Length < 2 || x.ReferenceNumber.Trim().Length > 60))
            .WithLocalizedMessage(() => PropertyDebtDetailsResources.Property_PropertyDebtDetails_RefNo_Error_Length);

            RuleFor(x => x.DebtType)
                .NotEmpty()
                .WithLocalizedMessage(() => PropertyDebtDetailsResources.Property_PropertyDebtDetails_DebtType_Error_Required);

            RuleFor(x => x.IsJointDebt)
           .NotEmpty()
           .WithLocalizedMessage(() => PropertyDebtDetailsResources.Property_PropertyDebtDetails_IsJointDebt_Error_Required);

            RuleFor(x => x.AmountOwe)
            .NotEmpty().WithLocalizedMessage(() => PropertyDebtDetailsResources.Property_PropertyDebtDetails_AmountOwe_Error_Mandatory)
            .InclusiveBetween(1, decimal.MaxValue)
            .WithLocalizedMessage(() => PropertyDebtDetailsResources.Property_PropertyDebtDetails_AmountOwe_Error_PositiveValueOnly)
            .SetValidator(new ScalePrecisionValidator(2, 99,
                () => PropertyDebtDetailsResources.Property_PropertyDebtDetails_AmountOwe_Error_Scale));

        }
    }
}