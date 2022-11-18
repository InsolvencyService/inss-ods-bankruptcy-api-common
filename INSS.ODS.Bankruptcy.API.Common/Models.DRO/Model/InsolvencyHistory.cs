using INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model.Enums;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class InsolvencyHistory
{
    public string Urn { get; set; }

    public bool? SubjectToInsolvencyProceedings { get; set; }

    public bool? SubjectToPreviousDRO { get; set; }

    public CurrentInsolvencyProceedingType? CurrentInsolvencyProceedingType { get; set; }

    public DateTime? DateOfProceedings { get; set; }

    public DateTime? DateOfPreviousDROProceedings { get; set; }

    public bool? PendingBankruptcyPetition { get; set; }
    public bool? PresentBankruptcyYourself { get; set; }

    public bool? CourtReferredToDro { get; set; }

    public string NameOfCourt { get; set; }

    public string CourtReference { get; set; }

    public string CreditorName { get; set; }

    public bool? CreditorsConsentToApply { get; set; }




    public bool? PreviousInsolvencyProceeding { get; set; }

    public PreviousInsolvencyProceedingType? PreviousInsolvencyProceedingType { get; set; }

    public DateTime? PreviousProceedingsStartDate { get; set; }




    public DebtManagementPlanType? DebtManagementPlanType { get; set; }

    public LegacyAddress DebtOrganisationAddress { get; set; }

    public string DebtOrganisationReference { get; set; }

    public DateTime? DebtOrganisatonProceedingsStartDate { get; set; }

    public string DebtOrganisationName { get; set; }

    public string PreviousInsolvencyProceedingText
    {
        get
        {
            if (!PreviousInsolvencyProceedingType.HasValue) { return ""; }

            switch (PreviousInsolvencyProceedingType.Value)
            {
                case (Enums.PreviousInsolvencyProceedingType.AdministrationOrder):
                    return "Administration Order";
                case (Enums.PreviousInsolvencyProceedingType.Bankruptcy):
                    return "Bankruptcy";
                case (Enums.PreviousInsolvencyProceedingType.BroU):
                    return "Bankruptcy Restrictions Order/Undertaking";
                case (Enums.PreviousInsolvencyProceedingType.Ccao):
                    return "County Court Administration Order";
                case (Enums.PreviousInsolvencyProceedingType.Dro):
                    return "Debt relief order";
                case (Enums.PreviousInsolvencyProceedingType.DrroU):
                    return "Debt Relief Restrictions Order/Undertaking";
                case (Enums.PreviousInsolvencyProceedingType.EnforcementOrder):
                    return "Enforcement Order";
                case (Enums.PreviousInsolvencyProceedingType.Iva):
                    return "Individual Voluntary Arrangement (inc. interim order)";
                default:
                    return "";
            }
        }
    }
}
