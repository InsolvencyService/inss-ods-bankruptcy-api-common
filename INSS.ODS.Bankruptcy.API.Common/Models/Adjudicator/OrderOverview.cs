using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator
{
    [DataContract]
    public class OrderOverview : ITableBase, IOrderOverview
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [MaxLength(12)]
        public string Urn { get; set; }

        [DataMember]
        [Required]
        public string OrderOverviewText { get; set; }

        [DataMember]
        [Required]
        public DateTime DateUpdated { get; set; }

        [DataMember]
        [Required]
        public string Owner { get; set; }

        [DataMember]
        public bool TransferCaseNote { get; set; }      
    }
}
