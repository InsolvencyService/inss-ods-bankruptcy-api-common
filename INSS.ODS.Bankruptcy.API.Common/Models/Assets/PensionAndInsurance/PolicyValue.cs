using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [Validator(typeof(PolicyValueValidator))]
    public class PolicyValue : IPolicyValue, ITableBase
    {
        public int Id { get; set; }

        [NotMapped]
        public int PolicyMainId { get; set; }

        public bool CurrentlyReceivingPayment { get; set; }

        [NotMapped]
        //Used only by the viewmodel for displaying the string value of radio button 
        //Shold be [NOTMAPPED' on the entity model
        public string CurrentlyReceivingPaymentOptions { get; set; }

        public decimal? CurrentWorth { get; set; }

    }
}