using System;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class FinancialSummaryDto
    {
        [DataMember]
        public PropertyDetails PropertyDetails{ get; set; }

        [DataMember]
        public IList<MortgageAndSecuredDebtCreditor> MortgageAndDebtCreditors { get; set; }

    }
}