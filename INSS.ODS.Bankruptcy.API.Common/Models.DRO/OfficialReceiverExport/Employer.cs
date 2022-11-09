using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class Employer
    {
        public String EmployerName;
        public String PayrollNumber;
        public String JobTitle;
        public Address Address;
        public DateTime EmploymentStartDate;
    }
}
