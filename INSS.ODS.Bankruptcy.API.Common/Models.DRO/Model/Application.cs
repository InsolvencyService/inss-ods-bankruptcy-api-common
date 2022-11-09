using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model
{
    public class Application
    {
        public string Urn { get; set; }
        public DateTime StartDate { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public ApplicationStatus Status { get; set; }
        public int PaymentReferenceId { get; set; }
        public string FurtherComments { get; set; }
        public bool AddressWithheld { get; set; }
        public bool SubmittedAgainstAdvice { get; set; }
        public string CaseNotes { get; set; }
        public bool IsOwner { get; set; }
        public string DroReference { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? LastEdited { get; set; }
        public DateTime? DueForDeletionEmailSentDate { get; set; }
        public DateTime? InactiveWarningEmailSentDate { get; set; }
    }
}
