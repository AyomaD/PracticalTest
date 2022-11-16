using OpenQA.Selenium;
using PracticalTest.Base;

namespace PracticalTest.Pages
{
    public class HomePage : BasePage
    {
        public By vehical = By.XPath("//h3[contains(text(),'Vehicles')]");
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public Vehicles clickOnVehicals() {
            waitTillElementDisplayed(webDriver.FindElement(vehical));
            webDriver.FindElement(vehical).Click();
            
            return new Vehicles(webDriver);
        }
    }
}
