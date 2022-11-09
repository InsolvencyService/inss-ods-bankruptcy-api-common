using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class ContactDetailsTests
    {
        [TestMethod]
        public void ContactDetailsValidModel()
        {
            var contactDetails = new ContactDetails();

            contactDetails.Email = "Email@Email.com";
            contactDetails.Mobile  = "01212334567";
            contactDetails.Telephone = "01212334567";

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(contactDetails);

            Assert.IsTrue(modelState.IsValid);
        }


        [TestMethod]
        public void ContactDetailsTelephoneNumberValidation()
        {
            var mockController = new MockTestController();

            var contactDetails = new ContactDetails();

            contactDetails.Email = "Email@Email.com";
            contactDetails.Mobile = "01212334567";

            //Valid tests

            contactDetails.Telephone = "01212334567";
            var modelState = mockController.TryFullModelValidation(contactDetails);
            Assert.IsTrue(modelState.IsValid);

            contactDetails.Telephone = "(01912) 362839";
            modelState = mockController.TryFullModelValidation(contactDetails);
            Assert.IsTrue(modelState.IsValid);

            contactDetails.Telephone = "+44 (01912) 362839";
            modelState = mockController.TryFullModelValidation(contactDetails);
            Assert.IsTrue(modelState.IsValid);

            contactDetails.Telephone = "+ 44 01912 362839";
            modelState = mockController.TryFullModelValidation(contactDetails);
            Assert.IsTrue(modelState.IsValid);

            //Invalid tests
            contactDetails.Telephone = "$1234567890";
            modelState = mockController.TryFullModelValidation(contactDetails);
            Assert.IsFalse(modelState.IsValid);

            contactDetails.Telephone = "123456789";
            modelState = mockController.TryFullModelValidation(contactDetails);
            Assert.IsFalse(modelState.IsValid);

            contactDetails.Telephone = "123456789012345678901234561234567890123456789012345612345678901234567890123456" +
                                            "123456789012345678901234561234567890123456789012345612345678901234567890123456";
                                
            modelState = mockController.TryFullModelValidation(contactDetails);
            Assert.IsFalse(modelState.IsValid);

        }



    }
}
