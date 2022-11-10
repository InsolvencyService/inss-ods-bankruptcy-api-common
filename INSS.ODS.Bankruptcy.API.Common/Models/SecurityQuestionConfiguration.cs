using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class SecurityQuestionConfiguration : ISecurityQuestionConfiguration
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public int QuestionGroup { get; set; }

        [Required]
        [DataMember]
        public String SecurityQuestion { get; set; }
    }
}
