using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Debt
{
    [DataContract]
    public class PreferredCreditor : IPreferredCreditor, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string SourceRef { get; set; }

        [DataMember]
        public string CreditorName { get; set; }
        
        [DataMember]
        public virtual Address CreditorAddress { get; set; }
    }
}