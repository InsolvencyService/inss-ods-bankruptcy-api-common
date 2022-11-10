using INSS.ODS.Bankruptcy.API.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService
{
    [Serializable]
    public class PDFForm2_68_BankAccountSummaryVm
    {
        public PDFForm2_68_BankAccountSummaryVm()
        {
            
        }

        public PDFForm2_68_BankAccountSummaryVm(BankAccountDetails accountDetails, List<JointAccountOwner> jointAccountOwners)
        {
            if (accountDetails == null)
            {
                throw new ArgumentNullException("accountDetails");
            }

            AccountDetails = accountDetails;
            JointAccountOwners = jointAccountOwners;

            if (!string.IsNullOrEmpty(AccountDetails.BankDetails.BankName)) NumberOfLines++;
            if (!string.IsNullOrEmpty(AccountDetails.BankDetails.AddressLine1)) NumberOfLines++;
            if (!string.IsNullOrEmpty(AccountDetails.BankDetails.AddressLine2)) NumberOfLines++;
            if (!string.IsNullOrEmpty(AccountDetails.BankDetails.AddressLine3)) NumberOfLines++;
            if (!string.IsNullOrEmpty(AccountDetails.BankDetails.TownCity)) NumberOfLines++;
            if (!string.IsNullOrEmpty(AccountDetails.BankDetails.County)) NumberOfLines++;
            if (!string.IsNullOrEmpty(AccountDetails.BankDetails.PostCode)) NumberOfLines++;

            if (jointAccountOwners.Count() > NumberOfLines) NumberOfLines = JointAccountOwners.Count();
        }
        
        public List<JointAccountOwner> JointAccountOwners { get; set; }

        public BankAccountDetails AccountDetails { get; set; }

        public int NumberOfLines { get; set; }
    }
}