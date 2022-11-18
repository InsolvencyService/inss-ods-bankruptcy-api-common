using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    public class HouseholdMember : ITableBase, IHouseholdMember
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName
        {
            get;
            set;
        }

        [DataMember]
        public string LastName
        {
            get;
            set;
        }

        [DataMember]
        public string AgeGroup
        {
            get;
            set;
        }

        [DataMember]
        public string Relationship
        {
            get;
            set;
        }

        [DataMember]
        public string RealtionshipOther
        {
            get;
            set;
        }

        [DataMember]
        public bool FinanciallyDependent
        {
            get;
            set;
        }
        
        [NotMapped]
        public String FinanciallyDependentOption
        {
            get;
            set;
        }
    }
}
