using System;
using System.Collections.Generic;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Models;


namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService
{
    [Serializable]
    public class PDFBankruptcyApplication_BankDetailsVm
    {
        public PDFBankruptcyApplication_BankDetailsVm()
        {
            MainPageBankAccountSummaries = new List<PDFBankruptcyApplication_BankAccountSummaryVm>();
            ExtraInformationPageBankAccountSummaries = new List<PDFBankruptcyApplication_BankAccountSummaryVm>();
        }

        public PDFBankruptcyApplication_BankDetailsVm(IList<BankAccountDetails> accountDetails, IList<JointAccountOwner> jointAccountOwners)
        {
            MainPageBankAccountSummaries = new List<PDFBankruptcyApplication_BankAccountSummaryVm>();
            ExtraInformationPageBankAccountSummaries = new List<PDFBankruptcyApplication_BankAccountSummaryVm>();

            if ((accountDetails == null) || (accountDetails.Count == 0))
            {
                return;
            }

            var bankAccountSummaries = new List<PDFBankruptcyApplication_BankAccountSummaryVm>();

            //for each account detail create a summary vm
            foreach (var accountDetail in accountDetails)
            {
                List<JointAccountOwner> jointOwners = new List<JointAccountOwner>();

                if ((jointAccountOwners != null) && (jointAccountOwners.Count > 0))
                {
                    jointOwners = jointAccountOwners.Where(x => x.BankAccountDetails.Id == accountDetail.Id).ToList();
                }

                bankAccountSummaries.Add(new PDFBankruptcyApplication_BankAccountSummaryVm(accountDetail, jointOwners));
            }

            //now calculate how many of these will go onto the main page
            //and how many will go on to the extra page

            var numberOfLinesAllowed = 22;
            var numberOfLinesUsed = 0;

            if (bankAccountSummaries.Min(x => x.NumberOfLines) > numberOfLinesAllowed)
            {
                //everything needs to go to the end
                ExtraInformationPageBankAccountSummaries = bankAccountSummaries;
            }
            else
            {
                foreach (var bankAccountSummary in bankAccountSummaries.OrderBy(x => x.NumberOfLines))
                {
                    if ((bankAccountSummary.NumberOfLines + 1) <= (numberOfLinesAllowed - numberOfLinesUsed))
                    {
                        MainPageBankAccountSummaries.Add(bankAccountSummary);
                        numberOfLinesUsed = numberOfLinesUsed + bankAccountSummary.NumberOfLines + 1;
                    }
                    else
                    {
                        ExtraInformationPageBankAccountSummaries.Add(bankAccountSummary);
                    }
                }
            }
        }

        public IList<PDFBankruptcyApplication_BankAccountSummaryVm> MainPageBankAccountSummaries { get; set; }

        public IList<PDFBankruptcyApplication_BankAccountSummaryVm> ExtraInformationPageBankAccountSummaries { get; set; }

        public bool WillOnlyFitInExtraInformationSection
        {
            get
            {
                return (MainPageBankAccountSummaries.Count == 0) && (ExtraInformationPageBankAccountSummaries.Count > 0);
            }
        }

        public bool NoBankAccounts
        {
            get
            {
                return (MainPageBankAccountSummaries.Count == 0) && (ExtraInformationPageBankAccountSummaries.Count == 0);
            }
        }

    }
}