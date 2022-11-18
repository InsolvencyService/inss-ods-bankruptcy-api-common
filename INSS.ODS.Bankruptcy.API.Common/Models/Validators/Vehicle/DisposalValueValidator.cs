using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class DisposalValueValidator : AbstractValidator<IDisposalValue>
    {
        public DisposalValueValidator()
        {
            RuleFor(x => x.Amount)
               .InclusiveBetween(0, decimal.MaxValue)
               .WithMessage(DisposalValueResources.Vehicle_DisposalValue_VehicleValue_Error_PositiveValue)
               .ScalePrecision(2, 99).WithMessage(DisposalValueResources.Vehicle_DisposalValue_Amount_Error_Scale);
        }
    }
}