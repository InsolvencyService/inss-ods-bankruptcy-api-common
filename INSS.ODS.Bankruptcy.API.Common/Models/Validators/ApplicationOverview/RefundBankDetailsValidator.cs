using System;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.ApplicationOverview;
using INSS.ODS.Bankruptcy.API.Common.Resources.ApplicationOverview;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.ApplicationOverview
{
    public class RefundBankDetailsValidator: AbstractValidator<IRefundBankDetails>
    {
        public RefundBankDetailsValidator()
        {
            RuleFor(x => x.SortCode)
                .NotEmpty()
                .WithMessage(RefundBankDetailsResources.ApplicationOverview_RefundBankDetails_SortCode_Error_Mandatory);

            RuleFor(x => x.SortCode)
                .Must(x=> x.Length<=150)
                .When(x => !String.IsNullOrEmpty(x.SortCode))
                .WithMessage(RefundBankDetailsResources.ApplicationOverview_RefundBankDetails_SortCode_Error_MaxLength);

            RuleFor(x => x.AccountNumber)
                .NotEmpty()
                .WithMessage(RefundBankDetailsResources.ApplicationOverview_RefundBankDetails_AccountNumber_Error_Mandatory);

            RuleFor(x => x.AccountNumber)
                .Must(x => x.Length <= 150)
                .When(x => !String.IsNullOrEmpty(x.AccountNumber))
                .WithMessage(RefundBankDetailsResources.ApplicationOverview_RefundBankDetails_AccountNumber_Error_MaxLength);

            RuleFor(x => x.BankName)
                .NotEmpty()
                .WithMessage(RefundBankDetailsResources.ApplicationOverview_RefundBankDetails_BankName_Error_Mandatory);

            RuleFor(x => x.BankName)
                .Must(x => x.Length <= 150)
                .When(x => !String.IsNullOrEmpty(x.BankName))
                .WithMessage(RefundBankDetailsResources.ApplicationOverview_RefundBankDetails_BankName_Error_MaxLength);


            RuleFor(x => x.AccountHolder)
                .NotEmpty()
                .WithMessage(RefundBankDetailsResources.ApplicationOverview_RefundBankDetails_AccountHolder_Error_Mandatory);


            RuleFor(x => x.AccountHolder)
                .Must(x => x.Length <= 150)
                .When(x => !String.IsNullOrEmpty(x.AccountHolder))
                .WithMessage(RefundBankDetailsResources.ApplicationOverview_RefundBankDetails_AccountHolder_Error_MaxLength);

            RuleFor(x => x.AccountHolder)
                .Matches(RegularExpressions.FirstName_ValidPattern)
                .When(x => !String.IsNullOrEmpty(x.AccountHolder))
                .WithMessage(RefundBankDetailsResources.ApplicationOverview_RefundBankDetails_AccountHolder_Error_Format);
                
        }
    }
}
