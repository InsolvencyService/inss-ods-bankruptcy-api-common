using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
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