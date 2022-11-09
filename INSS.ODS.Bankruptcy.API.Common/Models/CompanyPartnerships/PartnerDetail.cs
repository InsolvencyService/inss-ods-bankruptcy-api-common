using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyPartnerships;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    [Validator(typeof(PartnerDetailValidator))]
    public class PartnerDetail : ITableBase, IBusinessPartnerDetail
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public virtual Address PartnerAddress { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }


    }
}
