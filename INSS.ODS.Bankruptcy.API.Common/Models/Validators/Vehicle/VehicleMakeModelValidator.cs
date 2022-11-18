using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class VehicleMakeModelValidator : AbstractValidator<IVehiclePartial>
    {
        public VehicleMakeModelValidator()
        {
            RuleFor(r => r.Make)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty()
            .WithMessage(VehicleResources.Vehicle_Vehicle_MakeModel_Error_AnyOneFieldRequired)
            .When(r => String.IsNullOrWhiteSpace(r.Model));
        }
    }
}