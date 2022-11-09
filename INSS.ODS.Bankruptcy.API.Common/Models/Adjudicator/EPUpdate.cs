using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator
{
    [DataContract]
    public class EPUpdate
    {
        [DataMember]
        [MaxLength(12)]
        public string Urn { get; set; }

        [DataMember]
        [Required]
        public bool EstablishmentProceedings { get; set; }

        [DataMember]
        [Required]
        public string Owner { get; set; }

    }
}
