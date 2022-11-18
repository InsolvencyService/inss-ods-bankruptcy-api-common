using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class DependentsNotLivingWithYou : ITableBase, IDependentsNotLivingWithYou<Address>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int? Age { get; set; }

        [DataMember]
        virtual public Address Address { get; set; }

        [DataMember]
        public string Relationship { get; set; }

        [DataMember]
        public string RelationshipOther { get; set; }

    }
}
