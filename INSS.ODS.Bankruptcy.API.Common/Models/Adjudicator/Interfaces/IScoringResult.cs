using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator;

public interface IScoringResult
{
    [DataMember]
    int Id { get; set; }

    [DataMember]
    [MaxLength(12)]
    string Urn { get; set; }

    [DataMember]
    string ScoringType
    {get; set;}

    [DataMember]
    string RuleDescription
    { get; set; }

    [DataMember]
    string Result
    { get; set; }

    [DataMember]
    string ResultData
    { get; set; }

    [DataMember]
    bool Passed
    { get; set; }

    [DataMember]
    int Importance { get; set; }
}
