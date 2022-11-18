namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

public class EmploymentDetail
{
    ///// <summary>
    ///// Map of occupation type to the ISCIS PrimaryCode
    ///// </summary>
    //public static Dictionary<string, int> OccupationTypeToPrimaryCodeMap = new Dictionary<string,int>()
    //{
    //    {"Self-Employed", 1},
    //    {"Employed", 2},
    //    {"Unemployed", 3},
    //    {"Housewife / husband", 4},
    //    {"Company Director / Promoter", 5},
    //    {"Retired", 6},
    //    {"Trader", 7},
    //    {"Student", 8},
    //    {"Unknown", 9},
    //    {"Non-Trading", 10},
    //    {"Company / Partnership", 11},
    //    {"Non-Surrender", 12}
    //};

    //private string _occupationType;

    public List<string> OccupationType { get; set; }
    public List<Employer> Employer { get; set; }
    public List<PreviousTrading> PreviousTradingDetails { get; set; }
    public List<BusinessDetail> BusinessDetail { get; set; }
}
