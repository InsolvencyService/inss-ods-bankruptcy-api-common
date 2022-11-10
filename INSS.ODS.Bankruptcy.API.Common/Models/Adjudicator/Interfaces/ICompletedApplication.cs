using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator
{
    public interface ICompletedApplication
    {
        [DataMember]
        [MaxLength(12)]
        string Urn { get; set; }
        [DataMember]
        string BKTReference { get; set; }
        [DataMember]
        [Required]
        string FullName { get; set; }
        [DataMember]
        [Required]
        DateTime Received { get; set; }
        [DataMember]
        string Status { get; set; }
        [DataMember]
        [Required]
        string ApplicationData { get; set; }
        [DataMember]
        List<CaseNote> CaseNotes { get; set; }
        [DataMember]
        List<LogEntry> LogEntries { get; set; }

        [DataMember]
        List<ScoringResult> ScoringResults { get; set; }

        [DataMember]
        DateTime ApplicationLastUpdated { get; set; }
        [DataMember]
        string OrderOverview { get; set; }
        [DataMember]
        string OrderOverviewSimple { get; set; }
        [DataMember]
        bool? ECRegulationDoesNotApply { get; set; }
        [DataMember]
        bool? EstablishmentProceedings { get; set; }
        [DataMember]
        bool? PAV { get; set; }
        [DataMember]
        string CreditCheckSearchReference { get; set; }
    }
}
