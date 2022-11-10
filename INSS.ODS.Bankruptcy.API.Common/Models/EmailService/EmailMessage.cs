using INSS.ODS.Bankruptcy.API.Common.Models.EmailService.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace INSS.ODS.Bankruptcy.API.Common.Models.EmailService
{
    public class EmailMessage : IEmailMessage
    {
        [Required]
        public String From { get; set; }
        [Required]
        public String To { get; set; }
        public String Cc { get; set; }
        public String Bcc { get; set; }
        public String Subject { get; set; }
        [Required]
        public String TextBody { get; set; }
        public String HtmlBody { get; set; }

        public string AttachmentUrl { get; set; }
    }

}