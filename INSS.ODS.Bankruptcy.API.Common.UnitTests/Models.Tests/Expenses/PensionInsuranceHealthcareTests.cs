using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using System.Linq;


namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Expenses
{
    [TestClass]
    public class PensionInsuranceHealthcareTests
    {
        [TestMethod]
        public void PersonalDetailsValidModel()
        {
            var pensionInsuranceHealthcare = new PensionInsuranceHealthcare();

            pensionInsuranceHealthcare.AdultCareCosts = 10M;


            var context = new ValidationContext(pensionInsuranceHealthcare, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(pensionInsuranceHealthcare, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        public void PensionInsuranceHealthCareTotallingTest()
        {
            var pension = new PensionInsuranceHealthcare();

            Assert.IsTrue(pension.IsNotStarted);

            pension.PersonalPensionPayments = 100;
            pension.PersonalPensionPayments_Frequency = "per week";
            pension.LifeInsurance = 100;
            pension.LifeInsurance_Frequency = "per week";
            pension.HealthInsurance = 100;
            pension.HealthInsurance_Frequency = "per week";
            pension.PaymentProtectionInsurance = 100;
            pension.PaymentProtectionInsurance_Frequency = "per week";
            pension.PetInsurance = 100;
            pension.PetInsurance_Frequency = "per week";
            pension.VeterinaryBills = 100;
            pension.VeterinaryBills_Frequency = "per week";
            pension.AdultCareCosts = 100;
            pension.AdultCareCosts_Frequency = "per week";
            pension.PrescriptionsAndMedicines = 100;
            pension.PrescriptionsAndMedicines_Frequency = "per week";
            pension.Dentistry = 100;
            pension.Dentistry_Frequency = "per week";
            pension.Opticians = 100;
            pension.Opticians_Frequency = "per week";

            Assert.IsFalse(pension.IsNotStarted);
            Assert.AreEqual(4333.30m,pension.Total);

        }


    }
}
