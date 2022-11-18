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
    public class Address : ITableBase, IAddress
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
