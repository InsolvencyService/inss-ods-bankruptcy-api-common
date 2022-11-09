using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;


namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class SavingsFinesOtherCostsTests
    {
        [TestMethod]
        [TestCategory("Savings Fines Other Costs")]
        public void PersonalDetailsValidModel()
        {
            var savingsFinesOtherCosts = new SavingsFinesOtherCosts();

            savingsFinesOtherCosts.CourtFines = new List<Fine>{ new Fine() { Value = 10.0m, Frequency = "per week"}};

            var context = new ValidationContext(savingsFinesOtherCosts, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(savingsFinesOtherCosts, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }


        public void SavingsFinesOtherCostsTotallingTest()
        {
            var savings = new SavingsFinesOtherCosts();

            Assert.IsTrue(savings.IsNotStarted);

            savings.Savings = 100;
            savings.Savings_Frequency = "per week";
            savings.CourtFines.Add(new Fine {Frequency = "per week", Type="test", Value=100});
            savings.Expenses.Add(new Expense { Frequency = "per week", Type = "test", Value = 100 });

            Assert.IsFalse(savings.IsNotStarted);
            Assert.AreEqual(1299.99m, savings.Total);
            
        }

    }
}
