using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Creditors
{
    [DataContract]
    public class CreditorDetailDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string Reference { get; set; }

        [DataMember]
        public string DebtType { get; set; }

        [DataMember]
        public string DebtTypeOther { get; set; }



    }
}
