using System.ComponentModel;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public enum ApplicationStatusExportEnum
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
        ProcessorCompleted = 4
    }
}