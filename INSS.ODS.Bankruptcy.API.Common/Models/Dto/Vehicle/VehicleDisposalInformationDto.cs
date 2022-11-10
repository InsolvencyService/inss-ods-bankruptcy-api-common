using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Vehicle
{
    [DataContract]
    public class VehicleDisposalInformationDto 
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime SoldOrDisposedDate { get; set; }

        [DataMember]
        public string WhatHappened { get; set; }
    }
}