using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.DTO
{
    [DataContract]
    public class BankruptcyApplicationDTO
    {
        [DataMember]
        public string BKTReference { get; set; }

        [DataMember]
        public string ApplicantTitle { get; set; }

        [DataMember]
        public string ApplicantFirstName { get; set; }

        [DataMember]
        public string ApplicantMiddleNames { get; set; }

        [DataMember]
        public string ApplicantLastName { get; set; }

        [DataMember]
        public bool IsParvRestricted { get; set; }

        [DataMember]
        public string ApplicationIdentityJson { get; set; }
    }
}
