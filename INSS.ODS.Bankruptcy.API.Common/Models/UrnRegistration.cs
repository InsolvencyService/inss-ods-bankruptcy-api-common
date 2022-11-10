using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    [Index(nameof(URN), IsUnique = true, Name = "Ix_Unique_URN_Constraint")]
    public class UrnRegistration : IUrnRegistration
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        public String URN { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(16)]
        public String ClientName { get; set; }
    }
}
