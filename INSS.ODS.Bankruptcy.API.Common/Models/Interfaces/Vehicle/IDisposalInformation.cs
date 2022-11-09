using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle
{
    public interface IVehicleDisposalInformation
    {
        int Id { get; set; }

        DateTime SoldOrDisposedDate { get; set; }

        string WhatHappened { get; set; }
    }
}