using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.BktReference;

namespace INSS.ODS.Bankruptcy.API.Common.Models.BktReference
{
    [DataContract]
    public class BktRegistration : IBktRegistration
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        public string BktReference
        {
            get
            {
                return $"BKT{Id:0000000}";
            }
        }
    }
}
