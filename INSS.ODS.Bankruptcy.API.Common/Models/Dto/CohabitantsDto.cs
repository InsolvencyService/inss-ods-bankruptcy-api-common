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
    public class HouseholdMembersDto
    {
        [Required]
        [DataMember]
        public Address CurrentAddress { get; set; }

        [Required]
        [DataMember]
        public IList<HouseholdMember> HouseholdMembers { get; set; }
    }
}
