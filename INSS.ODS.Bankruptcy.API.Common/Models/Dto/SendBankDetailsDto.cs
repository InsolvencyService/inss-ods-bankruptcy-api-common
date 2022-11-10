using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class SendBankDetailsDto
    {

        [DataMember]
        public string Urn { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string BankName { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public string SortCode { get; set; }


        [DataMember]
        public string ADJReference { get; set; }



    }
}