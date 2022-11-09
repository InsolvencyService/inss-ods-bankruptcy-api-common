using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public static class DateValidation 
    {

        public static bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }

        public static bool BeAfter1900Date(DateTime date)
        {
            if (date <= new DateTime(1900, 1, 1))
                return false;
            return true;
        }

        public static bool BeInThePast(DateTime date)
        {
            if (date > DateTime.Now)
                return false;
            return true;
        }

        public static bool BeAfter1900NullableDate(DateTime? date)
        {
            if (date.Value <= new DateTime(1900, 1, 1))
                return false;
            return true;
        }

        public static bool BeInThePastNullableDate(DateTime? date)
        {
            if (date.Value > DateTime.Now)
                return false;
            return true;
        }
    }
}

