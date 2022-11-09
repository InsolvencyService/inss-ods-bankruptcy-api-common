using FluentValidation;
using FluentValidation.Results;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class OwnVehicleAdditionalDetailsValidator<T> : AbstractValidator<IOwnVehicleAdditionalDetails<T>> where T : IAddress
    {
        public OwnVehicleAdditionalDetailsValidator()
        {
            RuleFor(r => r.IsFinanceOutstanding)
           .NotEmpty()
           .WithLocalizedMessage(() => OwnVehicleResources.Vehicle_OwnVehicle_FinanceOutstanding_Error_Required);

            RuleFor(x => x.Address)
                .SetValidator(new OwnVehicleAddressValidator())
                .When(r => r.IsVehicleKeptAtHomeAddress == true);

            RuleFor(x => x.Address)
                .SetValidator(new AddressValidator())
                .When(r => r.IsVehicleKeptAtHomeAddress == false);
        }
    }
}