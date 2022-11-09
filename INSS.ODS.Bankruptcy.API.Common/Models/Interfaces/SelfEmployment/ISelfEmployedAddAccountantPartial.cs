using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ISelfEmployedAddAccountantPartial
    {
        [DataType(DataType.Text)]
        string AccountantName { get; set; }



    }
}
