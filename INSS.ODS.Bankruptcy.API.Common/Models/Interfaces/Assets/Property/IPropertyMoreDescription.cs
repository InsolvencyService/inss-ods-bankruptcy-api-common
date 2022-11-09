using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPropertyMoreDescription
    {
        int Id { get; set; }

        string SharedOwnership { get; set; }

        decimal? Worth { get; set; }

        DateTime PurchaseOrFinanceStartedDate { get; set; }

        string NatureOfInterest { get; set; }

        string OtherNatureOfInterest { get; set; }
    }
}