using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Validator(typeof(ApplicantSecurityQuestionAnswerItemValidator))]
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
}