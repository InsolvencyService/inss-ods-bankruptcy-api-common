using INSS.ODS.Bankruptcy.API.Common.Constants;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public enum ApplicationStatus
{
    [Description(ApplicationStatusNames.InProgress)]
    InProgress = 0,
    [Description(ApplicationStatusNames.UserSubmitted)]
    UserSubmitted = 1,
    [Description(ApplicationStatusNames.ProcessorRequested)]
    ProcessorRequested = 2,
    [Description(ApplicationStatusNames.ProcessorRetrieved)]
    ProcessorRetrieved = 3,
    [Description(ApplicationStatusNames.ProcessorCompleted)]
    ProcessorCompleted = 4,
    [Description(ApplicationStatusNames.Approved)]
    Approved = 5,
    [Description(ApplicationStatusNames.Declined)]
    Declined = 6,
    [Description(ApplicationStatusNames.UnderReview)]
    UnderReview = 7,
    [Description(ApplicationStatusNames.ReviewedAndDeclined)]
    ReviewedAndDeclined = 8,
    [Description(ApplicationStatusNames.UnderAppeal)]
    UnderAppeal = 9,
    [Description(ApplicationStatusNames.AwaitingInformation)]
    AwaitingInformation = 10
}