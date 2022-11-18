using INSS.ODS.Bankruptcy.API.Common.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.ComponentModel.DataAnnotations.Schema;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    public class EmployeeDetail : ITableBase, IEmployeeDetail
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public virtual Address EmployeeAddress { get; set; }


        [DataMember]
        public bool? MoneyOwed { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public virtual SelfEmployedEmployeeMoneyOwed SelfEmployedEmployeeMoneyOwed { get; set; }
    }
}
