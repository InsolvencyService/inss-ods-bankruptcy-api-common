using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Debt
{
    [DataContract]
    public class PreferredCreditorRelationship : IPreferredCreditorRelationship, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string RelationshipToYou { get; set; }

        [DataMember]
        public string RelationshipToYouOther { get; set; }
    }
}