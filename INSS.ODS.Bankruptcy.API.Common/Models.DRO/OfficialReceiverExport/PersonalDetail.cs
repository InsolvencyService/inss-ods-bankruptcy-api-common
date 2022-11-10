using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class PersonalDetail
    {
        ///// <summary>
        ///// Map of ethnicity to ISCIS Lookup Value Code
        ///// </summary>
        //public static Dictionary<string, string> EthnicityToLookupCode = new Dictionary<string, string>()
        //{
        //    { "Bangladeshi", "BANGLEDESHI" },
        //    { "Indian", "INDIAN" },
        //    { "Other Asian Background", "OTHER_ASIAN_BACKGROUND" },
        //    { "Pakistani", "PAKISTANI" },
        //    { "African", "AFRICAN" },
        //    { "Caribbean", "CARIBBEAN" },
        //    { "Other Black Background", "OTHER_BLACK_BACKGROUND" },
        //    { "Chinese", "CHINESE_SUB" },
        //    { "Other Mixed Background", "OTHER_MIXED_BACKGROUND" },
        //    { "White and Asian", "WHITE_ASIAN" },
        //    { "White and Black African", "WHITE_BLACK_AFRICAN" },
        //    { "White and Black Caribbean", "WHITE_BLACK_CARIBBEAN" },
        //    { "British Other", "BRITISH_OTHER" },
        //    { "British English", "BRITISH_ENGLISH" },
        //    { "Irish", "IRISH" },
        //    { "Other White Background", "OTHER_WHITE_BACKGROUND" },
        //    { "British Welsh", "BRITISH_WELSH" },
        //    { "British Scottish", "BRITISH_SCOTTISH" }
        //};

        public string Surname { get; set; }
        public string Forename { get; set; }
        public string MiddleNames { get; set; }
        public string TitleName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string BirthPlace { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public int? DependentChildrenUnder14 { get; set; }
        public int? DependentChildren14To18 { get; set; }
        public int? DependentOthers { get; set; }
        public Address CurrentAddress { get; set; }
        public string HomeTelephone { get; set; }
        public string MobileTelephone { get; set; }
        public string DaytimeTelephone { get; set; }
        public string Email { get; set; }
        public string NINumber { get; set; }
        public string TaxReference { get; set; }
        public string TaxOffice { get; set; }
        public string Ethnicity { get; set; }
        public string OtherEthnicity { get; set; }
        public string NationalityName { get; set; }
        public string OtherNationality { get; set; }
        public bool? RegisteredDisabled { get; set; }
        public List<string> Disabilities { get; set; }
        public string OtherDisability { get; set; }
        public bool? DisabilityImpairedFormCompletion { get; set; }
        public string DisabilityHowOvercome { get; set; }
        public string DisabilityHowAffectedFormCompletion { get; set; }
        public bool? HaveLivedOrHadPrincipalLivingInUkWales { get; set; }
        public bool? CurrentlyOrPrincipallyInUkWales { get; set; }
        public bool? CarriedOnBusinessUkInLast3yrs { get; set; }
        public List<OtherName> OtherNames { get; set; }
        public List<Address> PreviousAddresses { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(MiddleNames))
                {
                    return $"{Forename} {Surname}";
                }
                else
                {
                    return $"{Forename} {MiddleNames} {Surname}"; 
                }
            }
        }
    }
}
