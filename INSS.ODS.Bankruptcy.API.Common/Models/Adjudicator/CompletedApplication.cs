using INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator.Constants;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator;

[DataContract]
public class CompletedApplication : ITableBase, ICompletedApplication
{

    [DataMember]
    public int Id { get; set; }

    public string BKTReference { get; set; }

    public string ApplicationData
    { get; set; }

    public DateTime ApplicationLastUpdated
    { get; set; }

    public List<CaseNote> CaseNotes
    { get; set; }

    public string FullName
    { get; set; }

    public List<LogEntry> LogEntries
    { get; set; }

    public string OrderOverview
    { get; set; }

    public string OrderOverviewSimple
    { get; set; }

    public DateTime Received
    { get; set; }

    public string Status
    { get; set; }

    public string Urn
    { get; set; }

    public List<ScoringResult> ScoringResults
    { get; set; }

    public bool? PAV
    { get; set; }

    public bool? ECRegulationDoesNotApply
    { get; set; }

    public bool? EstablishmentProceedings 
    { get; set; }

    public string CreditCheckSearchReference
    { get; set; }

    [DataMember]
    public DateTime? DateOrderMade
    { get; set; }

    [DataMember]
    public DateTime? DateOrderRejected
    { get; set; }

    [DataMember]
    public bool RefundIssued { get; set; }

    [DataMember]
    public DateTime? RefundIssuedDate { get; set; }

    [DataMember]
    public bool RequiresBankruptcyStatusUpdate { get; set; }

    public void UpdateStatus(string newStatus)
    {
        Status = newStatus;

        if (Status == StatusConstants.ORDER_MADE
            || Status == StatusConstants.REJECTED
            || Status == StatusConstants.REVIEW_REQUESTED
            || Status == StatusConstants.REJECTED_AFTER_REVIEW
            || Status == StatusConstants.APPEALED
            || Status == StatusConstants.APPEAL_DISMISSED
            || Status == StatusConstants.AWAITING_INFORMATION
            || Status == StatusConstants.INFORMATION_RECEIVED)
        {
            RequiresBankruptcyStatusUpdate = true;
        }
    }

}
