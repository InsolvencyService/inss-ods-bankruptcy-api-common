using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator
{
    [DataContract]
    public class CompletedApplicationDetail : ITableBase, ICompletedApplicationDetail
    {
        [DataMember]
        public int Id { get; set; }

        public string Urn { get; set; }

        public string FullName { get; set; }


        public string Received { get; set; }

        public string Status { get; set; }


        public string ApplicationData { get; set; }


        public string DateOfBirth { get; set; }

        public string NINumber { get; set; }


        public string Telephone { get; set; }


        public string Address { get; set; }


        public string AnnualIncome { get; set; }

        public string TotalDebt { get; set; }

    }
}
