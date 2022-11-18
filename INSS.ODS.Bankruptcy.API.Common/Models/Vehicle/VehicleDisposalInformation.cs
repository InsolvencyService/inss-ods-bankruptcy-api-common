using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Vehicle
{
    [DataContract]
    public class VehicleDisposalInformation : ITableBase, IVehicleDisposalInformation
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime SoldOrDisposedDate { get; set; }

        [DataMember]
        public string WhatHappened { get; set; }
    }
}