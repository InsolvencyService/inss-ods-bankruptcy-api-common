using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator
{
    [DataContract]
    public class CreditCheckResponse
    {
        [DataMember]
        [MaxLength(12)]
        public string Urn { get; set; }

        [DataMember]
        [Required]
        public List<ScoringResult> ScoringResults { get; set; }

        [DataMember]
        [Required]
        public string CreditCheckReference { get; set; }

    }
}
