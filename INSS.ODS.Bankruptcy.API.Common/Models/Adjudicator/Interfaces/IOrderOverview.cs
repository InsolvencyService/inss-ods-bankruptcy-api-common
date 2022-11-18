namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator;

public interface IOrderOverview
{
    string Urn { get; set; }

    string OrderOverviewText { get; set; }

    DateTime DateUpdated { get; set; }

    string Owner { get; set; }
}
