using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class HomeAddress : ITableBase, IHomeAddress
{
    public int Id { get; set; }

    [Required]
    [DataMember]
    public virtual Address HomeRegistrationAddress { get; set; }
}
