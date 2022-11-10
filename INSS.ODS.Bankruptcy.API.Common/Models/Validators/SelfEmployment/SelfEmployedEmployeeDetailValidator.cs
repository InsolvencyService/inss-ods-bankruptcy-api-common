﻿using System.Text.RegularExpressions;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships
{
    public class SelfEmployedEmployeeDetailValidator : CompositeValidator<IEmployeeDetail>
    {
        public SelfEmployedEmployeeDetailValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());

            RuleFor(x => x.MoneyOwed)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => EmployeeDetailResources.EmployeeDetail_MoneyOwed_Required)
                .When(x => !x.MoneyOwed.HasValue);

        }
    }
}