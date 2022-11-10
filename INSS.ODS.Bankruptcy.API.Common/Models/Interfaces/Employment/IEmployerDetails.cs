using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IEmployerDetails
    {
        string EmployerName { get; set; }

        Address EmployerAddress { get; set; }

        DateTime? DateStarted { get; set; }

        DateTime? DateStopped { get; set; }
    }
}