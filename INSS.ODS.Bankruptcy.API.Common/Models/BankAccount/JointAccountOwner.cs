using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class JointAccountOwner : ITableBase, IJointAccountOwner
{
    [DataMember]
    public int Id { get; set; }

    [Required]
    [DataMember]
    public string FirstName { get; set; }

    [Required]
    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public BankAccountDetails BankAccountDetails { get; set; }
}
