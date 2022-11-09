using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account
{
    public class GroupMembershipStatusRequest
    {
        public Guid Id { get; set; }
        public bool Approved { get; set; }
    }
}
