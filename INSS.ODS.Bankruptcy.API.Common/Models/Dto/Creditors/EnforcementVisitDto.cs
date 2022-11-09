using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Creditors
{
    [DataContract]
    public class EnforcementVisitDto
    {


        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int CreditorId { get; set; }

        [DataMember]
        public string CreditorName { get; set; }

        [DataMember]
        public bool? ItemsSeizedOrSold { get; set; }

        [DataMember]
        public DateTime VisitDate { get; set; }

        [DataMember]
        public Decimal? ValueSeized { get; set; }

        [DataMember]
        public string ItemsSeized { get; set; }


    }
}
