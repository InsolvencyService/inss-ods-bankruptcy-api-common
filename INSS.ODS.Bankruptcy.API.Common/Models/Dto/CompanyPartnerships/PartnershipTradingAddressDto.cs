using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.CompanyPartnerships
{
    [DataContract]
    public class PartnershipTradingAddressDto
    {
        public int Id { get; set; }


        [DataMember]
        public virtual Address BusinessAddress { get; set; }


        [DataMember]
        public DateTime TradingStartedDate { get; set; }

        [DataMember]
        public DateTime? TradingStoppedDate { get; set; }



        [DataMember]
        public DateTime PartnershipStartedTradingDate { get; set; }

        [DataMember]
        public DateTime? PartnershipStoppedTradingDate { get; set; }
    }
}
