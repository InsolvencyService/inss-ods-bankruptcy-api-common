using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class SelfEmploymentIncome : ITableBase, ISelfEmploymentIncome
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Profit { get; set; }

        [DataMember]
        public string Profit_Frequency { get; set; }

        [DataMember]
        public DateTime? AccountingPeriodStart { get; set; }

        [DataMember]
        public DateTime? AccountingPeriodEnd { get; set; }

        [NotMapped]
        public decimal? Total
        {
            get
            {
                if (IsNotStarted) { return null; }

                return ValueFrequencyNormalisation.Normalise(Profit ?? 0, Profit_Frequency);

            }
        }


        [NotMapped]
        public bool IsNotStarted
        {
            get
            {
                return Profit == null;
                  
            }
        }
    }

}