namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

public class InsolvencyHistory
{
    public string InsolvencyReasonName { get; set; }
    public string OtherReasonForDebt { get; set; }
    public bool? HavePendingBankruptcyPetition { get; set; }
    public string CourtName { get; set; }
    public string CourtReference { get; set; }
    public bool? PresentedPetitionYourself { get; set; }
    public string CreditorName { get; set; }
    public bool? CourtReferredToDro { get; set; }
    public bool? HaveObtainedCreditorsConsent { get; set; }
    public PreviousInsolvency PreviousInsolvency { get; set; }
    public CurrentInsolvency CurrentInsolvency { get; set; }
    public FormalInsolvency FormalInsolvency { get; set; }
    public bool? SubjectToPreviousDRO { get; set; }
    public DateTime? DateOfPreviousDROProceedings { get; set; }
}
