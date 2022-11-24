using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
[Index(nameof(URN), IsUnique = true, Name = "Ix_Unique_URN_Constraint")]
public class UrnRegistration : IUrnRegistration
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    [Column(TypeName = "VARCHAR")]
    [StringLength(40)]
    public String URN { get; set; }

    [DataMember]
    [Column(TypeName = "VARCHAR")]
    [StringLength(16)]
    public String ClientName { get; set; }
}
