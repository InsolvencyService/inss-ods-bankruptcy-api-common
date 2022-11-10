using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account
{
    public class ResetPassword
    {
        public string Token { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
