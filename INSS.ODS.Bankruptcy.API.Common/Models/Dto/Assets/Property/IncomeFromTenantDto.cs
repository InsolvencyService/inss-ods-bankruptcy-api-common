﻿using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class IncomeFromTenantDto: IIncomeFromTenant
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? IncomeAmount { get; set; }

        [DataMember]
        public string IncomeFrequency { get; set; }

        [DataMember]
        public string ManagingAgent { get; set; }      
    }
}