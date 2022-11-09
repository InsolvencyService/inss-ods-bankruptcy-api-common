using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class PropertyDetails : ITableBase, IPropertyDetails, IJointOwnerList<PropertyJointOwnerDetails>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public virtual Address PropertyAddress { get; set; }

        [DataMember]
        public virtual PropertyDescription PropertyDescription { get; set; }

        [DataMember]
        public virtual PropertyMoreDescription PropertyMoreDescription { get; set; }

        [DataMember]
        public virtual List<PropertyDebtDetails> DebtDetails { get; set; }

        [DataMember]
        public IncomeFromTenant IncomeFromTenant { get; set; }

        [DataMember]
        public IncomeFromLodger IncomeFromLodger { get; set; }

        [DataMember]
        public ManagingAgentAddress ManagingAgentAddress { get; set; }
        
        [DataMember]
        public virtual List<PropertyJointOwnerDetails> PropertyJointOwners { get; set; }

        [DataMember]
        public virtual List<PropertyLodger> PropertyLodgers { get; set; }

        [DataMember]
        public virtual List<PropertyTenant> PropertyTenants { get; set; }

        [DataMember]
        public virtual BeneficialInterest PropertyBeneficialInterest { get; set; }


        [DataMember]
        [NotMapped]
        public decimal ApplicantInterestValueInProperty
        {
            get
            {
                if (PropertyBeneficialInterest != null)
                {
                    return PropertyBeneficialInterest.Amount ?? 0;
                }

                decimal? yourInterestInProperty = 0;

                var debtDetails = DebtDetails;
                var jointDebts = new List<PropertyDebtDetails>();
                var personalDebts = new List<PropertyDebtDetails>();
                var jointOwners = PropertyJointOwners;
                var PropertyValue = PropertyMoreDescription?.Worth;
                decimal? sharePercentage = 0;
                decimal? equityAmount = 0;
                decimal? equityShare = 0;
                decimal? totalJointDebtAmount = 0;
                decimal? totalPersonalDebtAmount = 0;

                sharePercentage = (jointOwners != null && jointOwners.Count > 0) ? (decimal)jointOwners.Find(x => x.IsSelf == true).JointOwnerShare : 0;

                if (debtDetails?.Count > 0)
                {
                    foreach (var item in debtDetails)
                    {
                        if (item.IsJointDebt != "Yes - with another person" && item.IsJointDebt != "No" && item.IsJointDebt != "Yes")
                        {
                            jointDebts.Add(item);
                        }
                        else
                        {
                            personalDebts.Add(item);
                        }
                    }

                    foreach (var item in jointDebts)
                    {
                        totalJointDebtAmount += item.AmountOwe;
                    }

                    foreach (var item in personalDebts)
                    {
                        totalPersonalDebtAmount += item.AmountOwe;
                    }
                }


                if (sharePercentage > 0)
                {
                    equityAmount = PropertyValue - totalJointDebtAmount;
                }
                else
                {
                    equityAmount = PropertyValue;
                }


                equityShare = (equityAmount > 0 && sharePercentage > 0) ? equityAmount * sharePercentage / 100 : 0;

                if (totalPersonalDebtAmount == 0 && totalJointDebtAmount == 0 && sharePercentage == 0)// no debt
                {
                    yourInterestInProperty = PropertyValue;
                }
                else if (totalPersonalDebtAmount == 0 && totalJointDebtAmount == 0 && sharePercentage > 0)// no debt but joined owner
                {
                    yourInterestInProperty = equityShare;
                }
                else if (jointDebts.Count > 0) //joint debt
                {
                    if (equityShare > 0 && totalPersonalDebtAmount >= 0)
                    {
                        yourInterestInProperty = equityShare - totalPersonalDebtAmount;
                    }
                    else if (equityAmount != 0 && equityShare == 0 && totalPersonalDebtAmount > 0)
                    {
                        yourInterestInProperty = equityAmount - totalPersonalDebtAmount;
                    }
                    else if (equityShare == 0 && totalPersonalDebtAmount > 0)
                    {
                        yourInterestInProperty = 0 - totalPersonalDebtAmount;
                    }
                    else
                    {
                        yourInterestInProperty = equityAmount;
                    }
                }
                else //personal debt only
                {
                    if (sharePercentage > 0)
                    {
                        yourInterestInProperty = equityShare - totalPersonalDebtAmount;
                    }
                    else
                    {
                        yourInterestInProperty = equityAmount - totalPersonalDebtAmount;
                    }

                }


                return yourInterestInProperty ?? 0;

            }
        }



        [DataMember]
        [NotMapped]
        public bool IsCompleteRecord
        {
            get
            {
                //Main objects
                if (PropertyDescription == null) { return false; }
                if (PropertyMoreDescription == null) { return false; }

                //Tenants
                if (PropertyDescription.WhoLivesTenant)
                {
                    if (IncomeFromTenant == null || !PropertyTenants.Any()) { return false; }

                    if (IncomeFromTenant.ManagingAgent == "Yes")
                    {
                        if (ManagingAgentAddress == null) { return false; }
                    }
                }

                //Lodgers
                //Nb. If Lodger AND Tenants are selected, ignore the lodger in terms of completions (requires no further info)
                if (PropertyDescription.WhoLivesLodger && !PropertyDescription.WhoLivesTenant)
                {
                    if (IncomeFromLodger == null || !PropertyLodgers.Any())
                    {
                        return false;
                    }
                }

                //Joint owners
                if(PropertyMoreDescription.NatureOfInterest == MorePropertyDescriptionResources.Property_MorePropertyDescription_NatureOfInterest_JointOwner)
                {
                    if (!PropertyJointOwners.Any(x=> !x.IsSelf))
                    {
                        return false;
                    }

                    //also have to validate the joint ownership split
                    var validator = new PropertyJointOwnerListValidator<PropertyJointOwnerDetails>();
                    var validationResult = validator.Validate(this);

                    if (!validationResult.IsValid)
                    {
                        return false;
                    }
                }

                //Mortgage
                //no checks to make here

                return true;
            }
        }

        /// <summary>
        /// This interface implementation is here solely so that the joint owner validator can be invoked against this
        /// </summary>
        #region Interface implementation

        [NotMapped]
        public int PropertyId { get { return Id; } set{} }
        [NotMapped]
        public List<PropertyJointOwnerDetails> JointOwners { get { return PropertyJointOwners; } set {} }

        #endregion
    }
}