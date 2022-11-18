using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors
{
    public class CreditorDetailValidator: AbstractValidator<ICreditorDetail>
    {
        public CreditorDetailValidator()
        {
            RuleFor(x => x.Amount)
                .NotEmpty().WithMessage(CreditorDetailResources.Creditors_CreditorDetail_Amount_Error_Mandatory)
                .GreaterThan(0).WithMessage(CreditorDetailResources.Creditors_CreditorDetail_Amount_Error_MinValue)           
                .ScalePrecision(2, 99).WithMessage(CreditorDetailResources.Creditors_CreditorDetail_Amount_Error_Scale);

            RuleFor(x => x.Reference)
                .Length(3, 70).WithMessage(CreditorDetailResources.Creditors_CreditorDetail_Reference_Length)
                .When(x => !string.IsNullOrEmpty(x.Reference));

         
            RuleFor(x => x.DebtType)
                .NotNull()
                .WithMessage(CreditorDetailResources.Creditors_CreditorDetail_DebtType_Error_Mandatory);

            RuleFor(x => x.DebtType)
                .Must(x => false)
                .When(x => x.DebtType == "Other")
                .Unless(x => !String.IsNullOrWhiteSpace(x.DebtTypeOther))
                .WithMessage(CreditorDetailResources.Creditors_CreditorDetail_DebtType_Error_Other_OtherText);

            RuleFor(x=>x.DebtType)
                .Must(x => false)
                .When(x => x.DebtType == "Other" && !String.IsNullOrWhiteSpace(x.DebtTypeOther))
                .Unless(x => x.DebtTypeOther!=null && x.DebtTypeOther.Length >= 3)
                .WithMessage(CreditorDetailResources.Creditors_CreditorDetail_DebtType_Error_Other_MinLength);

            RuleFor(x => x.DebtType)
                .Must(x => false)
                .When(x => x.DebtType == "Other" && !String.IsNullOrWhiteSpace(x.DebtTypeOther))
                .Unless( x=> x.DebtTypeOther != null && x.DebtTypeOther.Length <= 50)
                .WithMessage(CreditorDetailResources.Creditors_CreditorDetail_DebtType_Error_Other_MaxLength);

        }
    }
}
