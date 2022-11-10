using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Vehicles
{
    public class VehicleFinanceAgreementViewModel
    {
        public decimal? HowMuchOwedToFinanceCompany { get; set; }

        public string AccountOrReferenceNumber { get; set; }

        public DateTime? AgreementStartDate { get; set; }

        public string FinanceCompanyName { get; set; }
    }
}