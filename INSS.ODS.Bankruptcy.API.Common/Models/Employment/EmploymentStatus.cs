using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Employment;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Employment
{
    [DataContract]
    public class EmploymentStatus: ITableBase, IEmploymentStatus
    {
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string Status { get; set; }

    }
}
