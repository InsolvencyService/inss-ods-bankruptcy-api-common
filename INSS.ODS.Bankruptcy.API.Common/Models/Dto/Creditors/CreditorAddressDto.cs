using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Creditors
{
    [DataContract]
   public class CreditorAddressDto
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Address_1 { get; set; }

        [DataMember]
        public string Address_2 { get; set; }

        [DataMember]
        public string Address_3 { get; set; }

        [DataMember]
        public string TownCity { get; set; }

        [DataMember]
        public string County { get; set; }

        [DataMember]
        public string PostCode { get; set; }

        [DataMember]
        public string Country { get; set; }

        [NotMapped]
        public string FullAddress
        {
            get
            {
                var addressFields = new List<String>();

                //Only add to array if not empty!
                if (!String.IsNullOrWhiteSpace(Address_1)) addressFields.Add(Address_1);
                if (!String.IsNullOrWhiteSpace(Address_2)) addressFields.Add(Address_2);
                if (!String.IsNullOrWhiteSpace(Address_3)) addressFields.Add(Address_3);
                if (!String.IsNullOrWhiteSpace(TownCity)) addressFields.Add(TownCity);
                if (!String.IsNullOrWhiteSpace(County)) addressFields.Add(County);
                if (!String.IsNullOrWhiteSpace(PostCode)) addressFields.Add(PostCode);
                if (!String.IsNullOrWhiteSpace(Country)) addressFields.Add(Country);

                return string.Join(", ", addressFields.ToArray());
            }
        }


    }
}
