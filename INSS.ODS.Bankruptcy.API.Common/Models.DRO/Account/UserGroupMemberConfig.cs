using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account
{
    public class UserGroupMemberConfig
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Approved { get; set; }
        public Guid Id { get; set; }
    }
}