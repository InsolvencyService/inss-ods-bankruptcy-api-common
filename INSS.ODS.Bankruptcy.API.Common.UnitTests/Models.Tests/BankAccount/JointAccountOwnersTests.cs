using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using INSS.ODS.Bankruptcy.API.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.BankAccount
{
    [TestClass]
    public class JointAccountOwnersTests
    {
        [TestMethod]
        public void JointAccountOwnersValidModel()
        {
            var jointAccountOwner = new JointAccountOwner()
            {
                FirstName = "John",
                LastName = "Henry"
            };

            var context = new ValidationContext(jointAccountOwner, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(jointAccountOwner, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        public void JointAccountOwnersInvalidModel()
        {
            var jointAccountOwner = new JointAccountOwner
            {
                FirstName = "",
                LastName = ""
            };

            var context = new ValidationContext(jointAccountOwner, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(jointAccountOwner, context, results, true);

            Assert.IsFalse(isModelStateValid);
        }

    }
}
