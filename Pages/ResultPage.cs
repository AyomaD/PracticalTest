using OpenQA.Selenium;
using PracticalTest.Base;

namespace PracticalTest.Pages
{
    public class ResultPage : BasePage
    {
        public By txtModelYear = By.XPath("//*[@id=\"app\"]/div[4]/div[1]/div[2]/div[1]//tr[2]/td[2]");
        public By txtTransmission = By.XPath("//*[@id=\"app\"]/div[4]/div[1]/div[2]/div[1]//tr[4]/td[2]");
        public By txtManufacturer = By.XPath("//*[@id=\"app\"]/div[4]/div[1]/div[2]/div[1]//tr[5]/td[2]");
        public By txtModel = By.XPath("//*[@id=\"app\"]/div[4]/div[1]/div[2]/div[1]//tr[6]/td[2]");
        public By searchResultTittle = By.XPath("//*[@id=\"app\"]/div[4]/div[1]/h2");

        public ResultPage(IWebDriver driver) : base(driver)
        {
        }

        public void waitTillNavigatedToResultPage() {
            waitTillElementDisplayed(webDriver.FindElement(searchResultTittle));
        }

        public string getModelYear() {
            scrollIntoView(webDriver.FindElement(txtModelYear));
            return webDriver.FindElement(txtModelYear).Text;
        }

        public string getTransmission()
        {
            scrollIntoView(webDriver.FindElement(txtTransmission));
            return webDriver.FindElement(txtTransmission).Text;
        }

        public string getManufacturer()
        {
            scrollIntoView(webDriver.FindElement(txtManufacturer));
            return webDriver.FindElement(txtManufacturer).Text;
        }

        public string getModel()
        {
            scrollIntoView(webDriver.FindElement(txtModel));
            return webDriver.FindElement(txtModel).Text;
        }
    }
}
