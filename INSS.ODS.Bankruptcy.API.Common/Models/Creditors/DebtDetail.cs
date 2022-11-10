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
    [Validator(typeof(DebtDetailValidator))]
    public class DebtDetail : IDebtDetail, ITableBase
    {
        public int Id { get; set; }

        [NotMapped]
        public bool ValidationHook { get; set; }

        [NotMapped]
        public bool RequiresReason { get; set; }

        [DataMember]
        public string ApproxDebtStartedDateRange { get; set; }

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



        [DataMember]
        public bool? SeizedOrSoldAssets { get; set; }

        [DataMember]
        public bool? AttachmentOfEarnings { get; set; }

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

            if (DebtRepayment) { result.Add(DebtDetailsResources.Creditors_DebtDetails_DebtRepayment_Label); }
            if (HouseholdBills) { result.Add(DebtDetailsResources.Creditors_DebtDetails_HouseholdBills_Label); }
            if (Holidays) { result.Add(DebtDetailsResources.Creditors_DebtDetails_Holidays_Label); }
            if (HomeImprovements) { result.Add(DebtDetailsResources.Creditors_DebtDetails_HomeImprovements_Label); }
            if (PaymentsToFamily) { result.Add(DebtDetailsResources.Creditors_DebtDetails_PaymentsToFamily_Label); }
            if (TradingExpenses) { result.Add(DebtDetailsResources.Creditors_DebtDetails_TradingExpenses_Label); }
            if (VehiclePurchase) { result.Add(DebtDetailsResources.Creditors_DebtDetails_VehiclePurchase_Label); }
            if (Wedding) { result.Add(DebtDetailsResources.Creditors_DebtDetails_Wedding_Label); }
            if (Gambling) { result.Add(DebtDetailsResources.Creditors_DebtDetails_Gambling_Label); }
            if (Other) { result.Add(String.Format("{0} - {1}","Other", Other_Text)); }

            return result;
        }

        [NotMapped]
        public CheckboxList ReasonsForDebt { get; set; }

        [NotMapped]
        public string ReasonsForDebtOther { get; set; }

        public DebtDetail()
        {
            ReasonsForDebt = new CheckboxList();
        }
    }
}
