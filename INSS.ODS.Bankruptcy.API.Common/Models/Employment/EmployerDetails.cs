using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    public class EmployerDetails : ITableBase, IEmployerDetails
    {
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string EmployerName { get; set; }

        [Required]
        [DataMember]
        public virtual Address EmployerAddress { get; set; }

        [Required]
        [DataMember]
        public DateTime? DateStarted { get; set; }

        [DataMember]
        public DateTime? DateStopped { get; set; }

    }
}
