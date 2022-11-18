using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class PersonalDetails: ITableBase, IPersonalDetails
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string TitleOther { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleNames { get; set; }

        [DataMember]
        public string LastName { get; set; }
        
        [DataMember]
        public DateTime DateOfBirth { get; set; }
    }
}
