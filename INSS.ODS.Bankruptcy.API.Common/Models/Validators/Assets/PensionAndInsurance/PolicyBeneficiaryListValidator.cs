using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PolicyBeneficiaryListValidator<T> : AbstractValidator<IPolicyBeneficiaryList<T>> where T : IPolicyBeneficiaryDetail
    {
        public PolicyBeneficiaryListValidator()
        {

            RuleFor(x => x.PolicyBeneficiaries)
                .Must(SumOfBeneficiarySharesIsValid)
                .WithLocalizedMessage(() => OtherPolicyBeneficiariesResources.PensionAndInsurance_OtherPolicyBeneficiaries_Error_InvalidShares);
        }

        private bool SumOfBeneficiarySharesIsValid(IPolicyBeneficiaryList<T> instance, List<T> policyBeneficiaries)
        {
            //Ignore validation if relationship is not other
            if(policyBeneficiaries == null || !policyBeneficiaries.Any())
            {
                return false;
            }

            int numBeneficiaries = policyBeneficiaries.Count;
            var sum = policyBeneficiaries.Select(x => x.BeneficiaryShare).Sum();
            sum = Math.Round(sum, 1, MidpointRounding.AwayFromZero);
            double hundredPercent = Math.Round(100.0, 1, MidpointRounding.AwayFromZero);
            double equalShare = Math.Round( ((double) 100.0 / (policyBeneficiaries.Count)), 1, MidpointRounding.AwayFromZero);
            
            bool equallyDistributed = policyBeneficiaries.Where(x => x.BeneficiaryShare == equalShare).Count() == numBeneficiaries;

            //When equally distributed.. the sum may not be exactly 100 due to rounding! But it will be very close to 100%.
            return (sum == hundredPercent || equallyDistributed);
        }
    }
}
