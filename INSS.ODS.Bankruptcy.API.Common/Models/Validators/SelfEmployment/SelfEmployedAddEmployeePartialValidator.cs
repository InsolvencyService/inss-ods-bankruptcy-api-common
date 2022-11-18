using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class SelfEmployedAddEmployeePartialValidator : AbstractValidator<ISelfEmployedAddEmployeePartial>
    {

        public SelfEmployedAddEmployeePartialValidator()
        {

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage(EmployeeSummaryResources.EmployeeSummary_FirstName_Required )
                .Length(1, 70).WithMessage(EmployeeSummaryResources.EmployeeSummary_FirstName_Length );

            RuleFor(x => x.LastName)
              .NotEmpty().WithMessage(EmployeeSummaryResources.EmployeeSummary_LastName_Required)
              .Length(1, 39).WithMessage(EmployeeSummaryResources.EmployeeSummary_LastName_Length);

        }

       
    }
}

