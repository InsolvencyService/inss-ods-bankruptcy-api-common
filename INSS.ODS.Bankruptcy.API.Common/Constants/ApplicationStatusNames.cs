using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Constants
{
    public static class ApplicationStatusNames
    {
        public const string InProgress = "InProgress";
        public const string UserSubmitted = "UserSubmitted";
        public const string ProcessorRequested = "ProcessorRequested";
        public const string ProcessorRetrieved = "ProcessorRetrieved";
        public const string ProcessorCompleted = "ProcessorCompleted";
        public const string Approved = "Approved";
        public const string Declined = "Declined";
        public const string UnderReview = "UnderReview";
        public const string ReviewedAndDeclined = "ReviewedAndDeclined";
        public const string UnderAppeal = "UnderAppeal";
        public const string AwaitingInformation = "AwaitingInformation";
    }
}
