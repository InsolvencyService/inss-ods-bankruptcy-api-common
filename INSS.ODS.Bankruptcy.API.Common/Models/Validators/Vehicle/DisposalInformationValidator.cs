﻿using System;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class DisposalInformationValidator : AbstractValidator<IVehicleDisposalInformation>
    {
        public DisposalInformationValidator()
        {
            RuleFor(x => x.SoldOrDisposedDate)
                .NotEmpty().WithMessage(DisposalInfoResources.Vehicle_DisposalInfo_SoldOrDisposedDate_Error_Required)
                .LessThanOrEqualTo(DateTime.Today).WithMessage(DisposalInfoResources.Vehicle_DisposalInfo_SoldOrDisposedDate_Error_FutureDate)
                .GreaterThanOrEqualTo(Convert.ToDateTime("01/01/1900")).WithMessage(DisposalInfoResources.Vehicle_DisposalInfo_SoldOrDisposedDate_Error_MinDate);
            
            RuleFor(r => r.WhatHappened)
               .NotEmpty()
               .WithMessage(DisposalInfoResources.Vehicle_DisposalInfo_WhatHappened_Error_Required);

           
        }
    }
}