using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.AdjReference;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
[Index(nameof(Id), IsUnique = true, Name = "Ix_Unique_ADJ_Constraint")]
public class AdjRegistration : IAdjRegistration
{
    [DataMember]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [DataMember]
    [MaxLength(16)]
    public String ClientName { get; set; }

    public string AdjReference
    {
        get
        {
            return $"ADJ{Id:0000000}";
        }
    }
}