using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Declaration
{
    public class DeclarationViewModel
    {
        public ParvViewModel Parv { get; set; }
        //Parv
        
        public ApplicationSubmissionQuestions ApplicationSubmissionQuestions { get; set; }

        public DateTime? SubmittedDate { get; set; }
        public string SubmittedBy { get; set; }
        public string Reference { get; set; }
        public bool? VerifiedByGovUk { get; set; }

    }
}
