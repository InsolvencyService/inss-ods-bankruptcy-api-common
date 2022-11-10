using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class PropertyDebtDetailsDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PropertyId { get; set; }

        [DataMember]
        public string DebtType { get; set; }

        [DataMember]
        public string ReferenceNumber { get; set; }

        [DataMember]
        public DateTime DebtStartDate { get; set; }

        [DataMember]
        public decimal? AmountOwe { get; set; }

        [DataMember]
        public string IsJointDebt { get; set; }

        [DataMember]
        public int CreditorId { get; set; }
    }
}
