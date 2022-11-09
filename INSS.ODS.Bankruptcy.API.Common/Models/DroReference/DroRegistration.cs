using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.DroReference;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class DroRegistration : IDroRegistration
    {
        //[Index("Ix_Unique_DRO_Constraint", IsUnique = true)]
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataMember]
        [MaxLength(16)]
        public String ClientName { get; set; }

        public string DroReference
        {
            get
            {
                return Id.ToString();
            }
        }
    }

}