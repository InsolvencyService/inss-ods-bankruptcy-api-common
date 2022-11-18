using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class OwnVehicleValidator : AbstractValidator<IOwnVehicle>
    {
        public OwnVehicleValidator()
        {
            RuleFor(x => x.Price)
                .NotEmpty().WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Worth_Error_Required)
                //.InclusiveBetween(0, decimal.MaxValue).WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Worth_Error_PositveValueOnly)
                .ScalePrecision(2, 99).WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Worth_Error_DecimalPlaces)
                .GreaterThan(0)
                .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Worth_Error_AboveZero);

            RuleFor(r => r.VehicleUses)
                .Must(x => false)
                .When(x => x.UsageAsRelativeCare == false
                    && x.UsageAsSocialising == false
                    && x.UsageAsToSchool == false
                    && x.UsageAsWorkCommute == false
                    && x.UsageOther == false)
                .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Purpose_Error_Required);

            RuleFor(x => x.VehicleUses)
                .Must(x => false)
                .When(x => !string.IsNullOrWhiteSpace(x.UsageOtherText)
                    && (x.UsageOtherText.Trim().Length < 3 || x.UsageOtherText.Trim().Length > 100)
                    && (x.UsageOther == true))
                .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_UsageOtherText_Error_Length);

            RuleFor(x => x.VehicleUses)
                .Must(x => false)
                .When(x => string.IsNullOrWhiteSpace(x.UsageOtherText)
                    && (x.UsageOther == true))
                .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_UsageOtherText_Error_Required);
        }
    }
}