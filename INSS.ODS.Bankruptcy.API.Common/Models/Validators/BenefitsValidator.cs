using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class BenefitsValidator : AbstractValidator<IBenefits>
    {
        public BenefitsValidator()
        {
            RuleFor(x => x.Carers_Allowance)
                .InclusiveBetween(0,decimal.MaxValue)
                .WithMessage(BenefitsResources.Negative_Error_Carers);

            RuleFor(x => x.ChildBenefit)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithMessage(BenefitsResources.Negative_Error_Child_Benefit);


            RuleFor(x => x.ChildSupport)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithMessage(BenefitsResources.Negative_Error_Child_Support);

            RuleFor(x => x.ChildTaxCredit)
               .InclusiveBetween(0, decimal.MaxValue)
               .WithMessage(BenefitsResources.Negative_Error_Child_Tax_Credit);

            RuleFor(x => x.Council_Tax_Support)
               .InclusiveBetween(0, decimal.MaxValue)
               .WithMessage(BenefitsResources.Negative_Error_Council_Tax_Support);

            RuleFor(x => x.Disability)
               .InclusiveBetween(0, decimal.MaxValue)
               .WithMessage(BenefitsResources.Negative_Error_Disability);

             RuleFor(x => x.Housing_Benefit)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithMessage(BenefitsResources.Negative_Error_Housing_Benefit);

             RuleFor(x => x.Income_Support)
                 .InclusiveBetween(0, decimal.MaxValue)
                 .WithMessage(BenefitsResources.Negative_Error_Income_Support);

             RuleFor(x => x.JobSeekers)
                 .InclusiveBetween(0, decimal.MaxValue)
                 .WithMessage(BenefitsResources.Negative_Error_Jobseekers);


                        RuleFor(r => r.Other_Text)
                                        .NotEmpty()
                                        .When(r => r.Other_Value > 0 && r.Other_Value < decimal.MaxValue)
                                        .WithMessage(BenefitsResources.Negative_Error_OtherBenefit_Type);

                        RuleFor(r => r.Other_Value)
                            .InclusiveBetween(0, decimal.MaxValue)
                            .When(r => !string.IsNullOrEmpty(r.Other_Text))
                            .WithMessage(BenefitsResources.Negative_Error_OtherBenefit);

             RuleFor(x => x.Sick_Pay)
                  .InclusiveBetween(0, decimal.MaxValue)
                  .WithMessage(BenefitsResources.Negative_Error_Sick_Pay);

             RuleFor(x => x.Universal_Credit)
                  .InclusiveBetween(0, decimal.MaxValue)
                  .WithMessage(BenefitsResources.Negative_Error_Universal_Credit);

             RuleFor(x => x.Working_Tax_Credit)
                  .InclusiveBetween(0, decimal.MaxValue)
                  .WithMessage(BenefitsResources.Negative_Error_Working_Tax_Credit);

        }
    }
}
