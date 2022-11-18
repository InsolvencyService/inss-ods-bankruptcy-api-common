using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class ApplicationSubmissionQuestionsValidator : AbstractValidator<IApplicationSubmissionQuestions>
    {
        public ApplicationSubmissionQuestionsValidator()
        {

            RuleFor(r => r.IncludedDebtsFromAnotherApplication)
                     .NotEmpty()
                      .WithMessage(ContinueToSubmitResources.Application_ContinueToSubmit_OtherApplications_Required);



            RuleFor(r => r.SpokenToDebtAdvisor)
                     .NotEmpty()
                     .WithMessage(ContinueToSubmitResources.Application_ContinueToSubmit_DebtAdvisor_Required);

            RuleFor(r => r.AppliedForPAVOrder)
                     .NotEmpty()
                     .WithMessage(ContinueToSubmitResources.Application_ContinueToSubmit_PAV_Required);






        }
    }
}
