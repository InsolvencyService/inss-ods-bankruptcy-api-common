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
                .NotEmpty().WithLocalizedMessage(() => OwnVehicleResources.Vehicle_OwnVehicle_Worth_Error_Required)
                //.InclusiveBetween(0, decimal.MaxValue).WithLocalizedMessage(() => OwnVehicleResources.Vehicle_OwnVehicle_Worth_Error_PositveValueOnly)
                .SetValidator(new ScalePrecisionValidator(2, 99, () => OwnVehicleResources.Vehicle_OwnVehicle_Worth_Error_DecimalPlaces))
                .GreaterThan(0)
                .WithLocalizedMessage(
                    () => OwnVehicleResources.Vehicle_OwnVehicle_Worth_Error_AboveZero);

            RuleFor(r => r.VehicleUses)
                .Must(x => false)
                .When(x => x.UsageAsRelativeCare == false
                    && x.UsageAsSocialising == false
                    && x.UsageAsToSchool == false
                    && x.UsageAsWorkCommute == false
                    && x.UsageOther == false)
                .WithLocalizedMessage(() => OwnVehicleResources.Vehicle_OwnVehicle_Purpose_Error_Required);

            RuleFor(x => x.VehicleUses)
                .Must(x => false)
                .When(x => !string.IsNullOrWhiteSpace(x.UsageOtherText)
                    && (x.UsageOtherText.Trim().Length < 3 || x.UsageOtherText.Trim().Length > 100)
                    && (x.UsageOther == true))
                .WithLocalizedMessage(() => OwnVehicleResources.Vehicle_OwnVehicle_UsageOtherText_Error_Length);

            RuleFor(x => x.VehicleUses)
                .Must(x => false)
                .When(x => string.IsNullOrWhiteSpace(x.UsageOtherText)
                    && (x.UsageOther == true))
                .WithLocalizedMessage(() => OwnVehicleResources.Vehicle_OwnVehicle_UsageOtherText_Error_Required);
        }
    }
}