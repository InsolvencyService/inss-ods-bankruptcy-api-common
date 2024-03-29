using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PARVDetailValidator : AbstractValidator<IPARVDetail>
    {

        public PARVDetailValidator()
        {

            RuleFor(x => x.CourtName)
                .NotEmpty().WithMessage(PARVDetailsResources.PARVDetails_Court_Required)
                .Length(1, 100).WithMessage(PARVDetailsResources.PARVDetails_Court_Length);


            RuleFor(x => x.ApprovedDate)
              .NotEmpty().WithMessage(PARVDetailsResources.PARVDetails_Date_Approved_Required)
              .LessThanOrEqualTo(DateTime.Today)
              .WithMessage(PARVDetailsResources.PARVDetails_Date_Approved_Must_Be_In_The_Past);

            RuleFor(x => x.ApprovedDate)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                 .WithMessage(PARVDetailsResources.PARVDetails_Date_Approved_Must_Be_After_1900)
                .When(x => x.ApprovedDate != DateTime.MinValue);

        }


    }
}

