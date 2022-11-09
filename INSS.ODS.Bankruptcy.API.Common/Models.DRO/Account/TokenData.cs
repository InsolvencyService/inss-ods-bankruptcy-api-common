using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account
{
    [Serializable]
    public class TokenData
    {
        public string AccessToken { get; set; }

        public string TokenType { get; set; }

        public string RefreshToken { get; set; }

        public int ExpiresIn { get; set; }

        public string Username { get; set; }

        public DateTime Issed { get; set; }

        public DateTime Expires { get; set; }
        public string Role { get; set; }

        public bool IsAuthenticated()
        {
            return !string.IsNullOrEmpty(AccessToken);
        }
    }
}
