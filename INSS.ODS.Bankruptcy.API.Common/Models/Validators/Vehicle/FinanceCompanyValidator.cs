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
    public class FinanceCompanyValidator : AbstractValidator<IVehicleFinanceCompany>
    {
        public FinanceCompanyValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(FinanceCompanyResources.Vehicle_FinanceCompany_Name_Error_Required);
        }
    }
}