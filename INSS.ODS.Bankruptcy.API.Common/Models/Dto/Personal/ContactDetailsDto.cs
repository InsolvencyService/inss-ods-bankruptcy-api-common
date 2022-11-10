using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [Serializable]
    [DataContract]
    public class ContactDetailsDto
    {
        [DataMember]
        public ContactDetails ContactDetails { get; set; }

        [DataMember]
        public Address CurrentAddress { get; set; }
    }
}
