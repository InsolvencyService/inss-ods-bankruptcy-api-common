using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V1
{
    public class PersonalDetails
    {
        public string Urn { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Title? Title {get; set; }
        public string OtherTitle { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public bool? KnownByAnotherName { get; set; }
        public string OtherFirstName { get; set; }
        public string OtherLastName { get; set; }
        public List<OtherName> OtherNames { get; set; } 
        public string CityOfBirth { get; set; }
        public string NationalInsuranceNumber { get; set; }
        public int? DependantChildren { get; set; }
        public int? DependantOthers { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender? Gender { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Relationship? InRelationship { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Address CurrentAddress { get; set; }
        public bool? LivedAtOtherAddress { get; set; }
        public bool? LiveInEnglandOrWales { get; set; }
        public bool? EverLivedInEnglandOrWales { get; set; }
        public bool? BusinessInEnglandOrWales { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string EmailAddress { get; set; }
        public Address PreviousAddress { get; set; }
        public List<Address> PreviousAddresses { get; set; }
    }
}