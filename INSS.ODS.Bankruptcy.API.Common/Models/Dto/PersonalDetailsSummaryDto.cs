using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    public class PersonalDetailsSummaryDto
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string LastName { get; set; }
        public string RelationshipStatus { get; set; }
        public string OtherNames { get; set; }
        public string DateOfBirth { get; set; }
        public DateTime DateMovedIn { get; set; } 
        public List<HouseholdMember> HouseholdMembers { get; set; }
        public List<DependentsNotLivingWithYou> Dependants { get; set; }
        public ContactDetails ContactDetails { get; set; }

        public OccupancyDetails CurrentAddress { get; set; }
        public List<OccupancyDetails> PreviousAddresses { get; set; }

        public string Gender { get; set; }
        public string NationalInsuranceNumber { get; set; }
    }
}
