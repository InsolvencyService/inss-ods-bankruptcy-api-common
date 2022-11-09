using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Income
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class OtherNamesTests
    {
        [TestMethod]
        public void OtherNamesValidModel()
        {
            var othername = new OtherName
            {
                FirstName = "John",
                LastName = "Henry"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(othername);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void OtherNamesInvalidModel()
        {
            var othername = new OtherName
            {
                FirstName = "",
                LastName = ""
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(othername);

            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_Error_FirstNameOrLastNameRequired));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_Error_FirstNameOrLastNameRequired));
        }

    }
}
