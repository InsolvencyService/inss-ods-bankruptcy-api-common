using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator
{
    [DataContract]
    public class LogEntry : ITableBase, ILogEntry
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string BKTReference { get; set; }

        [DataMember]
        [MaxLength(12)]
        public string Urn { get; set; }

        [DataMember]
        [Required]
        public string LogAction { get; set; }

        [DataMember]
        [Required]
        public DateTime DateCreated { get; set; }

        [DataMember]
        [Required]
        public string Owner { get; set; }

       
    }
}
