using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    public class PropertyMoreDescriptionDto
    {
        public int Id { get; set; }       

        public string NatureOfInterest { get; set; }

        public string OtherNatureOfInterest { get; set; }

        public DateTime PurchaseOrFinanceStartedDate { get; set; }

        public string SharedOwnership { get; set; }

        public decimal? Worth { get; set; }
    }
}
