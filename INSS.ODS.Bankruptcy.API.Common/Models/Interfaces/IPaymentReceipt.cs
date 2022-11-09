using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPaymentReceipt
    {
        [Required(AllowEmptyStrings = true)]
        string PaymentProvider { get; set; }

        [Required(AllowEmptyStrings = false)]
        String TransactionId { get; set; }

        string AccountId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [NotInFuture(ErrorMessage="The Transaction Time cannot be in future.")]
        DateTime TranscationTime { get; set; }
        
        [Range(1, int.MaxValue)]
        int TransactionAmountInPence { get; set; }

        DateTime? StatusUpdateDate { get; set; }

        [ValidateJson]
        String ProviderMetadata { get; set; }

        bool VerifiedByProviderCallback { get; set; }

    }
}
