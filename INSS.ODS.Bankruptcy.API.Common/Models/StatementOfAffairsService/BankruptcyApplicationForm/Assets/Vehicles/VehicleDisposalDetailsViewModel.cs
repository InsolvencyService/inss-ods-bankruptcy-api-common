using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Vehicles
{
    public class VehicleDisposalDetailsViewModel
    {
        public DateTime? DisposalDate { get; set; }

        public string WhatHappened { get; set; }

        public decimal? AmountReceived { get; set; }
    }
}