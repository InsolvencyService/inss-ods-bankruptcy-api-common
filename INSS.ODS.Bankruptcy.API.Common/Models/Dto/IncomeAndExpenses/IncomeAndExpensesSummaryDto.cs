using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.IncomeAndExpenses
{
    [DataContract]
    public class IncomeAndExpensesSummaryDto
    {
        //Income
        [DataMember]
        public decimal? SelfEmploymentIncome { get; set; }
        [DataMember]
        public decimal? Wages { get; set; }
        [DataMember]
        public decimal? Benefits { get; set; }
        [DataMember]
        public decimal? Pensions { get; set; }
        [DataMember]
        public decimal? ContributionsFromOthers { get; set; }
        [DataMember]
        public decimal? OtherIncome { get; set; }
        //Expenses
        [DataMember]
        public decimal? HomeUtilities { get; set; }
        [DataMember]
        public decimal? PensionInsuranceHealthcare { get; set; }
        [DataMember]
        public decimal? Housekeeping { get; set; }
        [DataMember]
        public decimal? Transport { get; set; }
        [DataMember]
        public decimal? ChildcareAndMaintenance { get; set; }
        [DataMember]
        public decimal? PersonalLeisureExpenses { get; set; }
        [DataMember]
        public decimal? SavingsFinesOtherCosts { get; set; }

        //Totals
        [DataMember]
        public decimal? TotalIncome
        {
            get
            {
                if (Wages == null
                    && Benefits == null
                    && Pensions == null
                    && SelfEmploymentIncome == null
                   // && ContributionsFromOthers == null
                    && OtherIncome == null)
                {
                    return null;
                }

                return (Wages ?? 0)
                       + (Benefits ?? 0)
                       + (Pensions ?? 0)
                        + (SelfEmploymentIncome ?? 0)
                       // + (ContributionsFromOthers ?? 0)
                       + (OtherIncome ?? 0);
            }
        }

        [DataMember]
        public decimal? GrandTotalIncome
        {
            get
            {
                if (!TotalIncome.HasValue
                    && ContributionsFromOthers == null)
                {
                    return null;
                }

                return (TotalIncome ?? 0)
                       + (ContributionsFromOthers ?? 0);
            }
        }

        [DataMember]
        public decimal? TotalExpenses
        {
            get
            {
                if(HomeUtilities == null
                    && PensionInsuranceHealthcare == null
                    && Housekeeping == null
                    && Transport == null
                    && ChildcareAndMaintenance == null
                    && PersonalLeisureExpenses == null
                    && SavingsFinesOtherCosts == null)
                {
                    return null;
                }

                return (HomeUtilities ?? 0)
                       + (PensionInsuranceHealthcare ?? 0)
                       + (Housekeeping ?? 0)
                       + (Transport ?? 0)
                       + (ChildcareAndMaintenance ?? 0)
                       + (PersonalLeisureExpenses ?? 0)
                       + (SavingsFinesOtherCosts ?? 0);

            }
        }
    }
}
