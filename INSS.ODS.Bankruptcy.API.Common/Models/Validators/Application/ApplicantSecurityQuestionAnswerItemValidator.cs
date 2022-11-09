﻿using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class ApplicantSecurityQuestionAnswerItemValidator : AbstractValidator<ISecurityQuestionAnswerItem>
    {
        public ApplicantSecurityQuestionAnswerItemValidator()
        {
            AddValidationRules();             
        }
        public ApplicantSecurityQuestionAnswerItemValidator(string collectionName)
        {
            
            RuleFor(x => x)
            .NotEmpty()
            .OverridePropertyName(collectionName);
            
            AddValidationRules();
        }

        private void AddValidationRules()
        {
            RuleFor(x => x.SecurityQuestion)
            .NotEmpty()
            .WithLocalizedMessage(() => AnswerSecurityQuestionsResources.Application_AnswerSecurityQuestions_SecurityQuestion_Empty, x => x.ItemIndex + 1);

            RuleFor(x => x.SecurityAnswer)
            .NotEmpty()
            .WithLocalizedMessage(() => AnswerSecurityQuestionsResources.Application_AnswerSecurityQuestions_SecurityAnswer_Empty, x => x.ItemIndex + 1)
            .Length(3, 250)
            .WithLocalizedMessage(() => AnswerSecurityQuestionsResources.Application_AnswerSecurityQuestions_SecurityAnswer_FormatError, x => x.ItemIndex + 1);

        }
    }

}