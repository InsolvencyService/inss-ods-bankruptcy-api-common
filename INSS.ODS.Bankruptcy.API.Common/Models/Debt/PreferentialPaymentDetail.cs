using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Debt
{
    [DataContract]
    public class PreferentialPaymentDetail : IPreferentialPaymentDetail, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime? PaymentDate { get; set; }

        [DataMember]
        public decimal? PaymentAmount { get; set; }

        [DataMember]
        public string AssetName { get; set; }
    }
}