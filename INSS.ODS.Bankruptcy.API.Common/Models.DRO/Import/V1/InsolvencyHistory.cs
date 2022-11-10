using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V1
{
    public class InsolvencyHistory
    {
        public string Urn { get; set; }

        public bool? SubjectToInsolvencyProceedings { get; set; }

        public bool? SubjectToPreviousDRO { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
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

        [JsonConverter(typeof(StringEnumConverter))]
        public PreviousInsolvencyProceedingType? PreviousInsolvencyProceedingType { get; set; }

        public DateTime? PreviousProceedingsStartDate { get; set; }


        [JsonConverter(typeof(StringEnumConverter))]
        public DebtManagementPlanType? DebtManagementPlanType { get; set; }

        public Address DebtOrganisationAddress { get; set; }

        public string DebtOrganisationReference { get; set; }

        public DateTime? DebtOrganisatonProceedingsStartDate { get; set; }

        public string DebtOrganisationName { get; set; }
    }
}
