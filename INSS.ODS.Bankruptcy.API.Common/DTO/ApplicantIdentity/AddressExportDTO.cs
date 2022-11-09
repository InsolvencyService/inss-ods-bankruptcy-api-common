using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class AddressExportDTO
    {
        [DataMember]
        public int Id { get; set; }

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

        public string FullAddress
        {
            get
            {
                var addressFields = new List<string>();

                //Only add to array if not empty!
                if (!string.IsNullOrWhiteSpace(Address_1)) addressFields.Add(Address_1);
                if (!string.IsNullOrWhiteSpace(Address_2)) addressFields.Add(Address_2);
                if (!string.IsNullOrWhiteSpace(Address_3)) addressFields.Add(Address_3);
                if (!string.IsNullOrWhiteSpace(TownCity)) addressFields.Add(TownCity);
                if (!string.IsNullOrWhiteSpace(County)) addressFields.Add(County);
                if (!string.IsNullOrWhiteSpace(PostCode)) addressFields.Add(PostCode);
                if (!string.IsNullOrWhiteSpace(Country)) addressFields.Add(Country);

                return string.Join(", ", addressFields.ToArray());
            }
        }

    }
}