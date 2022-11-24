using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator;

[DataContract]
public class CaseNote : ITableBase, ICaseNote
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    [MaxLength(12)]
    public string Urn { get; set; }

    [DataMember]
    public int CaseNoteId { get; set; }

    [DataMember]
    [Required]
    public string NoteText { get; set; }

    [DataMember]
    [Required]
    public DateTime DateCreated { get; set; }

    [DataMember]
    [Required]
    public string Owner { get; set; }

    [DataMember]
    public bool TransferCaseNote { get; set; }


    [DataMember]
    public bool UseCaseNoteTextAsRejectionReason { get; set; }
}
