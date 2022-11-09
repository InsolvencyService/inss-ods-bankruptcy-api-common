using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.ComponentModel.DataAnnotations;
namespace INSS.ODS.Bankruptcy.API.Common.Models.EmailService.Interfaces
{
    public interface IEmailMessage 
    {
        [Required]
        String From { get; set; }
        
        [Required]
        String To { get; set; }
        
        String Cc { get; set; }
        
        String Bcc { get; set; }
        
        String Subject { get; set; }

        [Required]
        String TextBody { get; set; }
        String HtmlBody { get; set; }
    }
}
