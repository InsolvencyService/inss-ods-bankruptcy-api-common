using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator
{
    [DataContract]
    public class ECUpdate
    {
        [DataMember]
        [MaxLength(12)]
        public string Urn { get; set; }

        [DataMember]
        [Required]
        public bool ECRegulationDoesNotApply { get; set; }

        [DataMember]
        [Required]
        public string Owner { get; set; }

    }
}
