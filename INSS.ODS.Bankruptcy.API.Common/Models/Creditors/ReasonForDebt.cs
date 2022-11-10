using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;
using INSS.ODS.API.Common.Utilities.Types;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Creditors
{
    [DataContract]
    [Validator(typeof(ReasonForDebtValidator))]
    public class ReasonForDebt : IReasonForDebt, ITableBase
    {
        public int Id { get; set; }

        [NotMapped]
        public string ReasonForDebt_FieldsetStart { get; set; }

        [DataMember]
        public bool DebtRepayment { get; set; }

        [DataMember]
        public bool HouseholdBills { get; set; }

        [DataMember]
        public bool Holidays { get; set; }

        [DataMember]
        public bool HomeImprovements { get; set; }

        [DataMember]
        public bool PaymentsToFamily { get; set; }

        [DataMember]
        public bool TradingExpenses { get; set; }

        [DataMember]
        public bool VehiclePurchase { get; set; }

        [DataMember]
        public bool Wedding { get; set; }

        [DataMember]
        public bool Gambling { get; set; }

        [DataMember]
        public bool Other { get; set; }

        [DataMember]
        public string Other_Text { get; set; }

        [NotMapped]
        public bool AnySelected
        {
            get
            {
                return DebtRepayment
                       || HouseholdBills
                       || Holidays
                       || HomeImprovements
                       || PaymentsToFamily
                       || TradingExpenses
                       || VehiclePurchase
                       || Wedding
                       || Gambling
                       || Other;
            }
        }

        public IList<string> AsList()
        {
            var result = new List<String>();

            if (DebtRepayment) { result.Add(ReasonForDebtResources.Creditors_ReasonForDebt_DebtRepayment_Label); }
            if (HouseholdBills) { result.Add(ReasonForDebtResources.Creditors_ReasonForDebt_HouseholdBills_Label); }
            if (Holidays) { result.Add(ReasonForDebtResources.Creditors_ReasonForDebt_Holidays_Label); }
            if (HomeImprovements) { result.Add(ReasonForDebtResources.Creditors_ReasonForDebt_HomeImprovements_Label); }
            if (PaymentsToFamily) { result.Add(ReasonForDebtResources.Creditors_ReasonForDebt_PaymentsToFamily_Label); }
            if (TradingExpenses) { result.Add(ReasonForDebtResources.Creditors_ReasonForDebt_TradingExpenses_Label); }
            if (VehiclePurchase) { result.Add(ReasonForDebtResources.Creditors_ReasonForDebt_VehiclePurchase_Label); }
            if (Wedding) { result.Add(ReasonForDebtResources.Creditors_ReasonForDebt_Wedding_Label); }
            if (Gambling) { result.Add(ReasonForDebtResources.Creditors_ReasonForDebt_Gambling_Label); }
            if (Other) { result.Add(String.Format("{0} - {1}","Other", Other_Text)); }

            return result;
        }

        [NotMapped]
        public CheckboxList ReasonsForDebt { get; set; }

        [NotMapped]
        public string ReasonsForDebtOther { get; set; }

        public ReasonForDebt()
        {
            ReasonsForDebt = new CheckboxList();
        }
    }
}
