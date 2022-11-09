using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Debt
{
    [DataContract]
    public class PreferentialPayment : ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public PreferredCreditor PreferredCreditor { get; set; }

        [DataMember]
        public PreferredCreditorRelationship PreferredCreditorRelationship { get; set; }

        [DataMember]
        public PreferentialPaymentDetail PreferentialPaymentDetail { get; set; }
    }
}
