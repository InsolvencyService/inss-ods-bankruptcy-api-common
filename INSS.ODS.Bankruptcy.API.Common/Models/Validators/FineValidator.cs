using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class FineValidator : AbstractValidator<IFine>
    {
        public FineValidator()
        {
            RuleFor(r => r.Type)
                .NotEmpty()
                .WithMessage(SavingsFinesOtherCostsResources.Expenses_SavingsFinesOtherCosts_Fines_Type_Error_Empty)
                .When(r => r.Value.HasValue);

            RuleFor(r => r.Value)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(SavingsFinesOtherCostsResources.Expenses_SavingsFinesOtherCosts_Fines_Value_Error_Empty)
                .GreaterThanOrEqualTo(0)
                .WithMessage(SavingsFinesOtherCostsResources.Expenses_SavingsFinesOtherCosts_Fines_Value_Error_Negative)
                .ScalePrecision(2, 99).WithMessage(SavingsFinesOtherCostsResources.Expenses_SavingsFinesOtherCosts_Fines_Value_Error_Scale)
                .When(r => !string.IsNullOrEmpty(r.Type));
        }   
    }
}
