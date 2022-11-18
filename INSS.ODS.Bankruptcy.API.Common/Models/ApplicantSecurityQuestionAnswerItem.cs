using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

public class ApplicantSecurityQuestionAnswerItem : ISecurityQuestionAnswerItem
{
    public int Id { get; set; }
    /// <summary>
    /// Applicant security question
    /// </summary>
    public String SecurityQuestion { get; set; }

    /// <summary>
    /// Applicant security answer
    /// </summary>
    public String SecurityAnswer { get; set; }

    [NotMapped]
    public int ItemIndex { get; set; }

    public ApplicantSecurityQuestionAnswerItem()
    {

    }

    public ApplicantSecurityQuestionAnswerItem(ISecurityQuestionAnswerItem item)
    {
        if (item == null)
        {
            throw new ArgumentNullException();
        }

        Id = item.Id;
        SecurityQuestion = item.SecurityQuestion;
        SecurityAnswer = item.SecurityAnswer;
    }
}