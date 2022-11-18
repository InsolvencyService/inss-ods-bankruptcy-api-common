using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle
{   
    public interface IVehiclePartial
    {
        /// <summary>
        /// Make of Vehicle 
        /// </summary>
        [DataMember, DataType(DataType.Text)]
        string Make { get; set; }

        /// <summary>
        /// Model of Vehicle
        /// </summary>
        [DataMember, DataType(DataType.Text)]
        string Model { get; set; }

    }
    public interface IVehicleDetails : IVehiclePartial
    {
        int Id { get; set; }

        /// <summary>
        /// Vehicle Registration Number
        /// </summary>
        [DataMember, DataType(DataType.Text)]
        string RegistrationNumber { get; set; }

        /// <summary>
        /// Type of vehicle
        /// </summary>
        [DataMember, DataType(DataType.Text)]      
        string VehicleType { get; set; }

        /// <summary>
        /// Free text if Type of vehicle is Other.
        /// </summary>
        [DataMember, DataType(DataType.Text)]     
        string VehicleTypeOther { get; set; }

        /// <summary>
        /// What's the nature of your interest in the vehicle?
        /// </summary>
        [DataMember, DataType(DataType.Text)]
        string NatureOfInterestInVehicle { get; set; }
    }
}