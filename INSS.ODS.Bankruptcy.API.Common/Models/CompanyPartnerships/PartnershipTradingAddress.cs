﻿using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
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
    [Validator(typeof(CompanyPartnershipTradingAddressValidator))]
    public class PartnershipTradingAddress : ITableBase, ICompanyPartnershipTradingAddress
    {
        public int Id { get; set; }

        [Required]
        [DataMember]
        public virtual Address BusinessAddress { get; set; }

        [Required]
        [DataMember]
        public DateTime TradingStartedDate { get; set; }

        [DataMember]
        public DateTime? TradingStoppedDate { get; set; }




        [NotMapped]
        public DateTime PartnershipStartedDate { get; set; }

        [NotMapped]
        public DateTime? PartnershipStoppedDate { get; set; }
    }
}
