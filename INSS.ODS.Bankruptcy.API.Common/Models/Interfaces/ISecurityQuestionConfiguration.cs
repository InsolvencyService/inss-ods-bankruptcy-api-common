using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    
    public interface ISecurityQuestionConfiguration : ITableBase
    {
        [Required]
        [DataMember]
        int QuestionGroup { get; set; }
        
        [Required]
        [DataMember]
        String SecurityQuestion { get; set; }
    }
}
