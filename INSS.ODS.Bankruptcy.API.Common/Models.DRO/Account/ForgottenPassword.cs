using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account
{
    public class ForgottenPassword
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string TokenUrl { get; set; }
    }
}
