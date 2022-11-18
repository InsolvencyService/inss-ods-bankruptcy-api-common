using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator;

[DataContract]
public class ScoringResult : ITableBase, IScoringResult
{
    public int Id
    {
        get; set;
    }

    public string ScoringType
    {
        get; set;
    }

    public int Importance
    {
        get; set;
    }

    public bool Passed
    {
        get; set;
    }

    public string Result
    {
        get; set;
    }

    public string ResultData
    {
        get; set;
    }

    public string RuleDescription
    {
        get; set;
    }

    public string Urn
    {
        get; set;
    }
}

