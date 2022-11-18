namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator;

public interface ICaseNote
{
    string Urn { get; set; }

    string NoteText { get; set; }

    DateTime DateCreated { get; set; }

    string Owner { get; set; }

    bool TransferCaseNote { get; set; }

    bool UseCaseNoteTextAsRejectionReason { get; set; }

}
