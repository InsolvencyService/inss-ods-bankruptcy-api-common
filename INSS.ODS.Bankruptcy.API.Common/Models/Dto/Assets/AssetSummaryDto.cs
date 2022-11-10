using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.OtherAssets;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Assets
{
    [DataContract]
    public class AssetSummaryDto
    {
        #region Property

        [DataMember]
        public bool? HasProperty { get; set; }

        [DataMember]
        public decimal PropertyValue { get; set; }

        [DataMember]
        public bool HasIncompleteProperties { get; set; }

        [DataMember]
        public int PropertyCount { get; set; }

        [DataMember]
        public bool PropertySectionIsIncomplete
        {
            get
            {
                return (HasIncompleteProperties || !HasProperty.HasValue || (HasProperty.Value && PropertyCount == 0));
            }
        }

        #endregion

        #region Vehicles

        [DataMember]
        public bool? HasVehicle { get; set; }

        [DataMember]
        public string VehicleStatus { get; set; } //? check what this is for
        [DataMember]
        public decimal VehicleValue { get; set; }


        [DataMember]
        public bool HasIncompleteVehicles { get; set; }

        [DataMember]
        public int VehicleCount { get; set; }

        [DataMember]
        public bool VehicleSectionIsIncomplete
        {
            get
            {
                return (HasIncompleteVehicles || !HasVehicle.HasValue || (HasVehicle.Value && VehicleCount == 0));
            }
        }

        #endregion

        #region Policies


        [DataMember]
        public bool? HasInsurance { get; set; }

        [DataMember]
        public decimal InsuranceValue { get; set; }

        [DataMember]
        public bool HasIncompletePolicies { get; set; }

        [DataMember]
        public int PoliciesCount { get; set; }

        [DataMember]
        public bool PolicySectionIsIncomplete
        {
            get
            {
                return (HasIncompletePolicies || !HasInsurance.HasValue || (HasInsurance.Value && PoliciesCount == 0));
            }
        }

        #endregion

        #region Other

        [DataMember]
        public bool? HasOtherAssets { get; set; }


        [DataMember]
        public decimal OtherAssetsValue { get; set; }

        [DataMember]
        public bool OtherAssetsSectionIsIncomplete
        {
            get
            {
                //completion of other assets section is simply the presence of this flag set to true
                return !(HasOtherAssets.HasValue && HasOtherAssets.Value);
            }
        }


        #endregion

        #region Completion

        [DataMember]
        public bool IsComplete
        {
            get
            {
                return !PropertySectionIsIncomplete
                       && !VehicleSectionIsIncomplete
                       && !PolicySectionIsIncomplete
                       && !OtherAssetsSectionIsIncomplete;
            }
        }

        #endregion


    }
}