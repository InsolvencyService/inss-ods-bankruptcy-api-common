namespace INSS.ODS.Bankruptcy.API.Common.Models.Application.Extensions;

public static class ApplicantIdentityExtensions
{
    public static bool IsApplicationComplete(this ApplicantIdentity applicantIdentity)
    {
        //put in any logic here that you want to check for
        return true;
    }

    public static List<string> GetIncompleteSectionList(this ApplicantIdentity applicantIdentity)
    {
        //put in any sections that are not complete
        return new List<string>();
    }

    public static void CleanApplication(this ApplicantIdentity applicantIdentity)
    {
        //clean the application form
        //remove any unneeded stuff

        #region Cleaning creditors

        var idsToDelete = applicantIdentity.Creditors.Where(x => (x.AmountYouOwe == null) || (x.CreditorAction == null)).Select(y => y.Id).ToList();

        foreach (var id in idsToDelete)
        {
            var itemToRemove = applicantIdentity.Creditors.Single(x => x.Id == id);
            applicantIdentity.Creditors.Remove(itemToRemove);
        }

        #endregion

    }
}
