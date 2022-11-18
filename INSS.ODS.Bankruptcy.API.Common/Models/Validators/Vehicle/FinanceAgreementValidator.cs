using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class FinanceAgreementValidator : AbstractValidator<IFinanceAgreement>
    {
        public FinanceAgreementValidator()
        {
            RuleFor(x => x.Amount)
               .NotEmpty().WithMessage(FinanceAgreementResources.Vehicle_FinanceAgreement_AmountOwe_Error_Required)
               .InclusiveBetween(0, decimal.MaxValue)
               .WithMessage(FinanceAgreementResources.Vehicle_FinanceAgreement_AmountOwe_Error_PositveValueOnly)
               .ScalePrecision(2, 99).WithMessage(FinanceAgreementResources.Vehicle_FinanceAgreement_AmountOwe_Error_Scale);

            RuleFor(x => x.AgreementStartedDate)
                 .NotNull().WithMessage(FinanceAgreementResources.Vehicle_FinanceAgreement_Date_Error_Required)
                 .NotEmpty().WithMessage(FinanceAgreementResources.Vehicle_FinanceAgreement_Date_Error_Required)
                 .LessThanOrEqualTo(DateTime.Today)
                 .WithMessage(FinanceAgreementResources.Vehicle_FinanceAgreement_Date_Error_FutureDateNotAllowed)
                 .GreaterThanOrEqualTo(Convert.ToDateTime("01/01/1900"))
                 .When(x => x.AgreementStartedDate != null)
                 .WithMessage(FinanceAgreementResources.Vehicle_FinanceAgreement_Date_Error_MinimumDate);

            RuleFor(x => x.ReferenceNumber)
               .Must(x => false)
               .When(x => !string.IsNullOrWhiteSpace(x.ReferenceNumber) && x.ReferenceNumber.Trim().Length < 3)
               .WithMessage(FinanceAgreementResources.Vehicle_FinanceAgreement_ReferenceNumber_Error_MinLength);

            RuleFor(x => x.ReferenceNumber)
                .Must(x => false)
                .When(x => !string.IsNullOrWhiteSpace(x.ReferenceNumber) && x.ReferenceNumber.Trim().Length > 20)
                .WithMessage(FinanceAgreementResources.Vehicle_FinanceAgreement_ReferenceNumber_Error_MaxLength);

        }
    }
}