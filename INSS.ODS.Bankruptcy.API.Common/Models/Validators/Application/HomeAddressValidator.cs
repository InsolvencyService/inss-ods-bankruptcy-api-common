using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyPartnerships;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class HomeAddressValidator : AbstractValidator<IHomeAddress>
    {

        public HomeAddressValidator()
        {

          
        }


    }
}

