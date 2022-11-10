using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.DRO.Model.User
{
    [TestClass]
    public class UserAccountTests
    {
        private static Address address;

        [TestInitialize]
        public void Initialize()
        {
            address = new Address() { 
                Line1 = "123",
                Line2 = "High St",
                Line3 = "High Way",
                Town = "Newtown",
                County = "West Midlands",
                Postcode = "B12 34T",
                Country = "UK"
            };
        }

        [TestMethod]
        public void UserAccount_AddDeleteRole_UserHasDeleteRole()
        {
            var model = new UserAccount()
            {
                Id = "1234",
                FirstName = "Paul",
                LastName = "Jones",
                Email = "pj@testing.com",
                IscisIntermediaryId = 1,
                IsLocked = false,
                DeleteApplicationsRole = true,
                UserName = "PaulJones123",
                PhoneNumber = "1234567890",
                Roles = new List<string>() { "Super", "DeleteApplicationsRole" },
                OfficeAddress = address
            };

            var result = model.DeleteApplicationsRole;

            Assert.IsTrue((bool)result);
        }

        [TestMethod]
        public void UserAccount_RemoveDeleteRole_UserDoesNotHaveDeleteRole()
        {
            var model = new UserAccount()
            {
                Id = "1234",
                FirstName = "Paul",
                LastName = "Jones",
                Email = "pj@testing.com",
                IscisIntermediaryId = 1,
                IsLocked = false,
                DeleteApplicationsRole = false,
                UserName = "PaulJones123",
                PhoneNumber = "1234567890",
                Roles = new List<string>() { "Super" },
                OfficeAddress = address
            };

            var result = model.DeleteApplicationsRole;

            Assert.IsFalse((bool)result);
        }

    }
}

