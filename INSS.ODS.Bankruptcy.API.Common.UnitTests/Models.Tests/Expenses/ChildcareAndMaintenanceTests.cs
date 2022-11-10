using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Expenses
{
    [TestClass]
    public class ChildcareAndMaintenanceTests
    {
        [TestMethod]
        public void ChildcareAndMaintenanceValidModel()
        {
            var childCareAndMaintenance = new ChildcareAndMaintenance();

            childCareAndMaintenance.ChildSupport = 12.12m;
            childCareAndMaintenance.Childcare = 13.13m;
            childCareAndMaintenance.Dentistry = 14.14m;
            childCareAndMaintenance.Meals = 15.15m;
            childCareAndMaintenance.Nappies = 16.16m;
            childCareAndMaintenance.PocketMoney = 17.17m;
            childCareAndMaintenance.Prescriptions = 18.18m;
            childCareAndMaintenance.Transport = 19.19m;
            childCareAndMaintenance.Trips = 20.20m;
            childCareAndMaintenance.Uniforms = 21.21m;

            var context = new ValidationContext(childCareAndMaintenance, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(childCareAndMaintenance, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

        public void ChildcareAndMaintenanceTotallingTest()
        {
            var childcare = new ChildcareAndMaintenance();

            Assert.IsTrue(childcare.IsNotStarted);

            childcare.ChildSupport = 100m;
            childcare.ChildSupport_Frequency = "per week";
            childcare.Childcare = 100m;
            childcare.Childcare_Frequency = "per week";
            childcare.Nappies = 100m;
            childcare.Nappies_Frequency = "per week";
            childcare.Prescriptions = 100m;
            childcare.Prescriptions_Frequency = "per week";
            childcare.Dentistry = 100m;
            childcare.Dentistry_Frequency = "per week";
            childcare.Uniforms = 100m;
            childcare.Uniforms_Frequency = "per week";
            childcare.Meals = 100m;
            childcare.Meals_Frequency = "per week";
            childcare.Trips = 100m;
            childcare.Trips_Frequency = "per week";
            childcare.Transport = 100m;
            childcare.Transport_Frequency = "per week";
            childcare.PocketMoney = 100m;
            childcare.PocketMoney_Frequency = "per week";

            Assert.IsFalse(childcare.IsNotStarted);
            Assert.AreEqual(4333.30, childcare.Total);

        }
       
    }
}
