using INSS.ODS.Bankruptcy.API.Common.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    public class OccupancyDetails : ITableBase, IOccupancyDetails
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public virtual Address HomeAddress { get; set; }

        [DataMember]
        public DateTime? DateMovedIn { get; set; }

        [DataMember]
        public DateTime? DateMovedOut { get; set; }

        [DataMember]
        public bool IsCurrentAddress { get; set; }

        [DataMember]
        public string PropertyOwnership { get; set; }

        [DataMember]
        public string PropertyOwnershipOther { get; set; }
    }
}
