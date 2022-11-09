using INSS.ODS.Bankruptcy.API.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Expenses
{
    [TestClass]
    public class PersonalAndLeisureTests
    {
        [TestMethod]
        public void PersonalAndLeisureTotallingTest()
        {
            var personal  = new PersonalLeisureExpenses();

            Assert.IsTrue(personal.IsNotStarted);

            personal.ClothingAndFootwear = 100;
            personal.ClothingAndFootwear_Frequency = "per week";
            personal.Hairdressing = 100;
            personal.Hairdressing_Frequency = "per week";
            personal.HomePhoneInternetAndTV = 100;
            personal.HomePhoneInternetAndTV_Frequency = "per week";
            personal.MobilePhone = 100;
            personal.MobilePhone_Frequency = "per week";
            personal.LaundryAndDryCleaning = 100;
            personal.LaundryAndDryCleaning_Frequency = "per week";
            personal.HobbiesLeisureAndSport = 100;
            personal.HobbiesLeisureAndSport_Frequency = "per week";
            personal.NewspapersAndMagazines = 100;
            personal.NewspapersAndMagazines_Frequency = "per week";
            personal.Gifts = 100;
            personal.Gifts_Frequency = "per week";
            personal.Smoking = 100;
            personal.Smoking_Frequency = "per week";

            Assert.IsFalse(personal.IsNotStarted);
            Assert.AreEqual(3899.97m, personal.Total);
        }
    }
}
