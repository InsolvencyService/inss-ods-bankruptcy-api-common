using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    [Validator(typeof(ManagingAgentAddressValidator))]
    public class ManagingAgentAddress : IManagingAgentAddress, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public virtual Address AgentAddress { get; set; }

        [DataMember]
        public string AgentName { get; set; }        
    }
}