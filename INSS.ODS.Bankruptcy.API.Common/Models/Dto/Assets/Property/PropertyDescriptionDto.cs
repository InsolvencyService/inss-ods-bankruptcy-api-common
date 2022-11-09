using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class PropertyDescriptionDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string PropertyType { get; set; }

        [DataMember]
        public string OtherPropertyType { get; set; }

        [DataMember]
        public string OwnershipType { get; set; }

        [DataMember]
        public int BedroomCount { get; set; }

        [DataMember]
        public bool WhoLivesYou { get; set; }

        [DataMember]
        public bool WhoLivesSpouse { get; set; }

        [DataMember]
        public bool WhoLivesFormer { get; set; }

        [DataMember]
        public bool WhoLivesTenant { get; set; }

        [DataMember]
        public bool WhoLivesLodger { get; set; }
    }
}
