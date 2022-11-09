using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPersonalDetailsSummaryVm
    {
        string Title { get; set; }
        string FirstName { get; set; }
        string MiddleNames { get; set; }
        string LastName { get; set; }
        string RelationshipStatus { get; set; }
        string OtherNames { get; set; }
        string DateOfBirth { get; set; }
        DateTime DateMovedIn { get; set; }
        List<HouseholdMember> HouseholdMembers { get; set; }
        List<DependentsNotLivingWithYou> Dependants { get; set; }
        ContactDetails ContactDetails { get; set; }
    }
}
