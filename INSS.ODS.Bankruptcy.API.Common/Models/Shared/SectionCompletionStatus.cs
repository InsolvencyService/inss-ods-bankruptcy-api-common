using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    public class SectionCompletionStatus : ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool? PersonalSectionComplete { get; set; }

        [DataMember]
        public bool? EmploymentSectionComplete { get; set; }

        [DataMember]
        public bool? BankAccountsSectionComplete { get; set; }

        [DataMember]
        public bool? AssetsSectionComplete { get; set; }

        [DataMember]
        public bool? MoneyYouOweSectionComplete { get; set; }

        [DataMember]
        public bool? IncomeAndExpensesSectionComplete { get; set; }

        [DataMember]
        public bool? LegalProceedingsSectionComplete { get; set; }

        [DataMember]
        public bool? DebtHistorySectionComplete { get; set; }

    }
}