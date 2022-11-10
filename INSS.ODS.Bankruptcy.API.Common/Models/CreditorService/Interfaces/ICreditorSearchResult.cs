using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CreditorsService.Interfaces
{
    public interface ICreditorSearchResult
    {
         string SourceRef { get; }
         string Name { get; }
         string AddressLine1 { get; }
         string AddressLine2 { get; }
         string AddressLine3 { get; }
         string Town { get; }
         string County { get; }
         string PostCode { get; }
         string Country { get; }
    }
}