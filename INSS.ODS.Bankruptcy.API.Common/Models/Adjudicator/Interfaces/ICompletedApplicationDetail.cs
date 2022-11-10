using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator
{
    public interface ICompletedApplicationDetail
    {
        [DataMember]
        [MaxLength(12)]
        string Urn { get; set; }

        [DataMember]
        [Required]
        string FullName { get; set; }

        [DataMember]
        [Required]
        string Received { get; set; }

        [DataMember]
        [Required]
        string Status { get; set; }

        [DataMember]
        [Required]
        string ApplicationData { get; set; }

        [DataMember]
        [Required]
        string DateOfBirth { get; set; }

        [DataMember]
        [Required]
        string NINumber { get; set; }

        [DataMember]
        [Required]
        string Telephone { get; set; }

        [DataMember]
        [Required]
        string Address { get; set; }

        [DataMember]
        [Required]
        string AnnualIncome { get; set; }

        [DataMember]
        [Required]
        string TotalDebt { get; set; }
    }
}
