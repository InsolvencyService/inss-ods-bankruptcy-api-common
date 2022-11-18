using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Vehicle
{
    [DataContract]
    public class VehicleDetails : ITableBase, IVehicleDetails
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string RegistrationNumber { get; set; }

        public string VehicleType { get; set; }

        public string VehicleTypeOther { get; set; }

        public string NatureOfInterestInVehicle { get; set; }

        [DataMember]
        public VehicleDisposalInformation VehicleDisposalInformation { get; set; }

        [DataMember]
        public VehicleDisposalValue VehicleDisposalValue { get; set; }

        [DataMember]
        public OwnVehicle OwnVehicle { get; set; }

        [DataMember]
        public OwnVehicleAdditionalDetails OwnVehicleAdditionalDetails { get; set; }

        [DataMember]
        public ThirdPartyVehicle ThirdPartyVehicle { get; set; }

        [DataMember]
        public FinanceAgreement VehicleFinanceAgreement { get; set; }

        [DataMember]
        public VehicleFinanceCompany VehicleFinanceCompany { get; set; }

        [DataMember]
        public VehicleMotabilityDetails VehicleMotabilityDetails { get; set; }


        [DataMember]
        [NotMapped]
        public bool IsCompleteRecord
        {
            get
            {
                //Own vehicle
                if (NatureOfInterestInVehicle == VehicleResources.Vehicle_Vehicle_VehicleNatureOfInterest_Owner)
                {
                    if (OwnVehicle == null || OwnVehicleAdditionalDetails == null)
                    {
                        return false;
                    }

                    if (OwnVehicleAdditionalDetails.IsFinanceOutstanding == "Yes")
                    {
                        if (VehicleFinanceCompany == null || VehicleFinanceAgreement == null)
                        {
                            return false;
                        }
                    }
                }

                //Sold or disposed of
                if (NatureOfInterestInVehicle == VehicleResources.Vehicle_Vehicle_VehicleNatureOfInterest_Sold)
                {
                    if (VehicleDisposalInformation == null)
                    {
                        return false;
                    }

                    if (VehicleDisposalInformation.WhatHappened == DisposalInfoResources.Vehicle_DisposalInfo_WhatHappened_Sold ||
                        VehicleDisposalInformation.WhatHappened == DisposalInfoResources.Vehicle_DisposalInfo_WhatHappened_Scrapped)
                    {
                        if (VehicleDisposalValue == null)
                        {
                            return false;
                        }
                    }

                    if (VehicleDisposalInformation.WhatHappened == DisposalInfoResources.Vehicle_DisposalInfo_WhatHappened_Repossessed
                        || VehicleDisposalInformation.WhatHappened == DisposalInfoResources.Vehicle_DisposalInfo_WhatHappened_Returned)
                    {
                        if (VehicleFinanceCompany == null || VehicleFinanceAgreement == null)
                        {
                            return false;
                        }
                    }
                }

                //Vehicle you use regularly
                if (NatureOfInterestInVehicle == VehicleResources.Vehicle_Vehicle_VehicleNatureOfInterest_JustUseRegularly)
                {
                    if (ThirdPartyVehicle == null)
                    {
                        return false;
                    }                    
                }

                //Motability
                if (NatureOfInterestInVehicle == VehicleResources.Vehicle_Vehicle_VehicleNatureOfInterest_MotabilityScheme)
                {
                    if (VehicleMotabilityDetails == null)
                    {
                        return false;
                    }
                }

                return true;
                
            }
        }

    }
}