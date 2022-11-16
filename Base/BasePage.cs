using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace PracticalTest.Base
{
    public class BasePage
    {

        public IWebDriver webDriver;
        public WebDriverWait waitForElement;

        public BasePage(IWebDriver driver)
        {
            webDriver = driver;
            waitForElement = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(50000));
            waitForElement.PollingInterval = TimeSpan.FromMilliseconds(100);

        }
        public void waitTillElementDisplayed(IWebElement element)
        {
            waitForElement.Until(webDriver => {
                return element.Displayed;
            });
        }

        public void waitTillElementIsNotDisplayed(IWebElement element)
        {
            waitForElement.Until(webDriver => {
                return !element.Displayed;
            });
        }

        public void waitTillURLIsChanged(string expectedURL)
        {
            waitForElement.Until(webDriver => {
                return webDriver.Url.Equals(expectedURL);
            });
        }

        public void scrollIntoView(IWebElement element)
        {
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
