namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class EmploymentDetail
{
    public int? EmploymentId { get; set; }

    public string CompanyName { get; set; }

    public string PayrollNumber { get; set; }

    public string JobTitle { get; set; }

    public JobRole? JobRole { get; set; }

    public DateTime? DateEmploymentBegan { get; set; }

    public LegacyAddress BusinessAddress { get; set; }

    public EmploymentType? EmploymentType { get; set; }

    public string EmploymentTypeOther { get; set; }

    // business
    public string BusinessType { get; set; }

    public string BusinessName { get; set; }


    public bool? SoleTrader { get; set; }
    public bool IsPrimary { get; set; }
}