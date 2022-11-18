using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PropertyJointOwnerListValidator<T> : AbstractValidator<IJointOwnerList<T>> where T : IPropertyJointOwnerDetails
    {
        public PropertyJointOwnerListValidator()
        {
            RuleFor(x => x.JointOwners)
                .Must(SumOfJointOwnersShareIsValid)
                .WithMessage(JointOwnerDetailsResources.Property_JointOwnerDetails_Error_InvalidShares);
        }

        private bool SumOfJointOwnersShareIsValid(IJointOwnerList<T> instance, List<T> jointOwners)
        {
            //Ignore validation if relationship is not other
            if (jointOwners == null || !jointOwners.Any())
            {
                return false;
            }

            int numBeneficiaries = jointOwners.Count;
            var sum = jointOwners.Select(x => x.JointOwnerShare).Sum();
            sum = Math.Round(sum, 1, MidpointRounding.AwayFromZero);
            double hundredPercent = Math.Round(100.0, 1, MidpointRounding.AwayFromZero);
            double equalShare = Math.Round(((double)100.0 / (jointOwners.Count)), 1, MidpointRounding.AwayFromZero);

            bool equallyDistributed = jointOwners.Where(x => x.JointOwnerShare == equalShare).Count() == numBeneficiaries;

            //When equally distributed.. the sum may not be exactly 100 due to rounding! But it will be very close to 100%.
            return (sum == hundredPercent || equallyDistributed);
        }
    }
}