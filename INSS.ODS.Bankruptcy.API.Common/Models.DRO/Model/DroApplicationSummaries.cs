namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

/// <summary>
/// Used to populate application lists on the DRO website.
/// </summary>
public class DroApplicationSummaries
{
    public int TotalCount { get; set; }

    public List<DroApplicationSummary> SummaryList { get; set; }
}
