using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPolicyValue
    {
        int PolicyMainId { get; set; }
        //ViewModel translates "Yes" or "NO" value from CurrentlyReceivingPaymentOptions
        // to corresponding boolean value using a binder.
        //Used by the entity model to store the selected option as true/false.
        bool CurrentlyReceivingPayment { get; set; }

        //Used only by the viewmodel for displaying the string value of radio button 
        //Shold be [NOTMAPPED' on the entity model
        string CurrentlyReceivingPaymentOptions { get; set; }

        decimal? CurrentWorth { get; set; }
    }
}
