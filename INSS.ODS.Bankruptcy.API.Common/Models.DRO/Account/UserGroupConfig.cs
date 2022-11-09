using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account
{
    public class UserGroupConfig
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Approved { get; set; }
        public IEnumerable<UserGroupMemberConfig> Members { get; set; }
        public int GroupRequests { get; set; }
    }
}
