using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using Insolvency.Bankruptcy.App.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class LandlordOrAgentDetails : ITableBase, ILandlordOrAgentDetails
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public virtual Address Address { get; set; }
    }
}
