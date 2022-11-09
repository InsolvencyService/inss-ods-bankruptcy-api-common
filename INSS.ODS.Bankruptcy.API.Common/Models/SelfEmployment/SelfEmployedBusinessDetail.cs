using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    [Validator(typeof(SelfEmployedBusinessDetailValidator))]
    public class SelfEmployedBusinessDetail : ITableBase, ISelfEmployedBusinessDetail
    {
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string BusinessName { get; set; }

        [Required]
        [DataMember]
        public string BusinessType { get; set; }

        [Required]
        [DataMember]
        public DateTime TradingStartedDate { get; set; }

        [DataMember]
        public DateTime? TradingStoppedDate { get; set; }

        [DataMember]
        public IList<SelfEmployedBusinessName> BusinessNames
        {
            get;
            set;
        }

        [DataMember]
        public IList<SelfEmployedBusinessAddress> BusinessAddresses { get; set; }

        [DataMember]
        public SelfEmployedAdditionalBusinessDetail AdditionalBusinessDetail { get; set; }

        [DataMember]
        public IList<EmployeeDetail> EmployeeDetails { get; set; }

        [DataMember]
        public IList<FormerEmployeeDetail> FormerEmployeeDetails { get; set; }

        [DataMember]
        public IList<AccountantDetail> AccountantDetails { get; set; }
    }
}
