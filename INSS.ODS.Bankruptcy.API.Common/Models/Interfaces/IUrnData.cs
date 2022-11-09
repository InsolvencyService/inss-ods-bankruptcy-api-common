using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IUrnRegistration : ITableBase
    {
        //[Index("Ix_Unique_URN_Constraint", IsUnique=true)]
        
        [Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        String URN { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(16)]
        String ClientName { get; set; }
    }
}
