using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class PARVDetail : ITableBase, IPARVDetail
{
    public int Id { get; set; }

    [Required]
    [DataMember]
    public string CourtName { get; set; }

    [Required]
    [DataMember]
    public DateTime ApprovedDate { get; set; }
}
