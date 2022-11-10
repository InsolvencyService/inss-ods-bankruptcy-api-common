using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Creditors
{
    [DataContract]
    [Validator(typeof(CreditorActionValidator))]
    public class CreditorAction: ICreditorAction, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Boolean? ActionValue { get; set; }




    }
}
