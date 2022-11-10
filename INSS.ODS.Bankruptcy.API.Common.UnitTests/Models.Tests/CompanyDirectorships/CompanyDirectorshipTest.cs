using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.CompanyDirectorships
{
    [TestClass]
    public class CompanyDirectorshipTest
    {
        private CompanyDirectorshipValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new CompanyDirectorshipValidator();
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorshipInvalidModel_LimitedCompanyName()
        {
            var model = new CompanyDirectorship();

            model.LimitedCompanyName = "";
            _validator.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName, model);

            model.LimitedCompanyName = "1";
            _validator.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName, model);

            model.LimitedCompanyName = "12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901";
            _validator.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName, model);

            model.LimitedCompanyName = "My Company";
            _validator.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName, model);

            model.LimitedCompanyName = "My Company $";
            _validator.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName, model);
            
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorshipValidModel_LimitedCompanyName()
        {
            var model = new CompanyDirectorship();

            model.LimitedCompanyName = "My Company Ltd";
            _validator.ShouldNotHaveValidationErrorFor(x => x.LimitedCompanyName, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_IsCompanyRegisteredInTheUK_ShouldErrorOnInvalidValue()
        {
            var model = new CompanyDirectorship();

            _validator.ShouldHaveValidationErrorFor(x => x.IsCompanyRegisteredInTheUK, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_AreYourAnActiveDirector_ShouldErrorOnInvalidValue()
        {
            var model = new CompanyDirectorship();

            _validator.ShouldHaveValidationErrorFor(x => x.AreYouStillAnActiveDirector, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_AreYouAnActiveDirector_ShouldPassOnValidValue()
        {
            var model = new CompanyDirectorship()
            {
                AreYouStillAnActiveDirector = true
            };

            _validator.ShouldNotHaveValidationErrorFor(x => x.AreYouStillAnActiveDirector, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_IsCompanyRegisteredInTheUK_ShouldPassOnValidValue()
        {
            var model = new CompanyDirectorship()
            {
                IsCompanyRegisteredInTheUK = true
            };

            _validator.ShouldNotHaveValidationErrorFor(x => x.IsCompanyRegisteredInTheUK, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_CompanyRegistrationNumber_WhenCompanyIsRegisteredInUK_ShouldErrorOnInvalidValue()
        {
            var model = new CompanyDirectorship()
            {
                IsCompanyRegisteredInTheUK = true
            };

            model.CompanyRegistrationNumber = "";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);

            model.CompanyRegistrationNumber = "123456789";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);

            model.CompanyRegistrationNumber = "1234567";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);

            model.CompanyRegistrationNumber = "A1234567";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);

            model.CompanyRegistrationNumber = "ABC12345";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);

            model.CompanyRegistrationNumber = "AB12345B";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_CompanyRegistrationNumber_WhenCompanyIsRegisteredInUK_ShouldPassOnValidValue()
        {
            var model = new CompanyDirectorship()
            {
                IsCompanyRegisteredInTheUK = true,
                CompanyRegistrationNumber = ""
            };

            model.CompanyRegistrationNumber = "AB123456";
            _validator.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);

            model.CompanyRegistrationNumber = "12345678";
            _validator.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_CompanyRegistrationCountry_WhenCompanyIsNotRegisteredInUK_ShouldErrorOnInvalidValue()
        {
            var model = new CompanyDirectorship()
            {
                IsCompanyRegisteredInTheUK = false
            };
           
            model.CompanyRegistrationCountry = "";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry, model);

            model.CompanyRegistrationCountry = "A";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry, model);

            model.CompanyRegistrationCountry = "ABCEDFGHI!";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry, model);

            model.CompanyRegistrationCountry = "ABCDEFGHIJAABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJ";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry, model);

            model.CompanyRegistrationCountry = "12345678";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_CompanyRegistrationCountry_WhenCompanyIsRegisteredNotInUK_ShouldPassOnValidValue()
        {
            var model = new CompanyDirectorship()
            {
                IsCompanyRegisteredInTheUK = false,
                CompanyRegistrationNumber = ""
            };

            model.CompanyRegistrationCountry = "France";
            _validator.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationCountry, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_CompanyRegistrationNumber_WhenCompanyIsNotRegisteredInUK_ShouldErrorOnInvalidValue()
        {
            var model = new CompanyDirectorship()
            {
                IsCompanyRegisteredInTheUK = false
            };

            model.CompanyRegistrationNumber = "";
            _validator.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);

            model.CompanyRegistrationNumber = "123";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);

            model.CompanyRegistrationNumber = "123456789012345678901";
            _validator.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);
        }

        [TestMethod]
        [TestCategory("CompanyDirectorship")]
        public void CompanyDirectorship_CompanyRegistrationNumber_WhenCompanyIsRegisteredNotInUK_ShouldPassOnValidValue()
        {
            var model = new CompanyDirectorship()
            {
                IsCompanyRegisteredInTheUK = false,
                CompanyRegistrationNumber = ""
            };

            model.CompanyRegistrationNumber = "FR1234567890";
            _validator.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationNumber, model);
        }
    }
}
