using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.ApplicationOverview
{
    [DataContract]
    public class RefundBankDetailsDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string SortCode { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public string BankName { get; set; }
        [DataMember]
        public string AccountHolder { get; set; }
    }
}
