using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Creditors
{
    [DataContract]
    public class TypeOfActionTakenDto
    {


        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int CreditorId { get; set; }

        [DataMember]
        public string CreditorName { get; set; }

        [DataMember]
        public  string TypeOfAction { get; set; }

    }
}
