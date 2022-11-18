namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator;

public interface ILogEntry
{
    string Urn { get; set; }

    string LogAction { get; set; }

    DateTime DateCreated { get; set; }

    string Owner { get; set; }

    string BKTReference { get; set; }

}
