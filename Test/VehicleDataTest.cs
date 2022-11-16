using NUnit.Framework;
using PracticalTest.Base;
using PracticalTest.Pages;

namespace PracticalTest.Test
{
    [TestFixture]
    public class VehicleDataTest : TestBase
    {
        HomePage homePage;
        Vehicles vehicles;
        ResultPage resultPage;

        [Test]
        public void verifyVehicleDataTest() {
            homePage = new HomePage(GetDriver);

            vehicles = homePage.clickOnVehicals();
            vehicles.clickOnCar();
            vehicles.clickOnManufacturer("Suzuki");
            vehicles.clickOnModel("Alto");
            vehicles.enterYearOfManufacturer("2014");
            vehicles.clickOnTransmission("Auto");
            vehicles.clickOnCondition("Used");
            vehicles.clickOnFilter();
            resultPage = vehicles.clickOnResultLink();

            Assert.That(resultPage.getModelYear(), Is.EqualTo("2014"), "Model year should be 2014");
            Assert.That(resultPage.getTransmission(), Is.EqualTo("Automatic"), "Tranmission should be Automatic");
            Assert.That(resultPage.getManufacturer, Is.EqualTo("Suzuki"), "Manufacturer should be Suzuki");
            Assert.That(resultPage.getModel, Is.EqualTo("Alto"), "Model should be Alto");
        }
    }
}
