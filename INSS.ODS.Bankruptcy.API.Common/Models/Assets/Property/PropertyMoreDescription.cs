using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Validator(typeof(PropertyMoreDescriptionValidator))]
    [DataContract]
    public class PropertyMoreDescription : IPropertyMoreDescription
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NatureOfInterest { get; set; }

        [DataMember]
        public string OtherNatureOfInterest { get; set; }

        [DataMember]
        public DateTime PurchaseOrFinanceStartedDate { get; set; }

        [DataMember]
        public string SharedOwnership { get; set; }

        [DataMember]
        public decimal? Worth { get; set; }
    }
}