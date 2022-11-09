using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    public class AuthenticateApplicant : IAuthenticateApplicant
    {
        [DataMember]
        public String Urn { get; set; }

        [DataMember]
        public String Question { get; set; }

        [DataMember]
        public String SecurityAnswer { get; set; }
    }
}
