using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PracticalTest.Base;
using System.Xml.Linq;


namespace PracticalTest.Pages
{
    public class Vehicles : BasePage
    {
        public By lnkCar = By.XPath("//*[@id=\"carouselExampleIndicators\"]/div[1]/div/div[1]/span/a");
        public By selectManufacture = By.Id("manufacturer");
        public By selectModel = By.XPath("//*[@id=\"model\"]");
        public By selectTransmission = By.Id("transmission");
        public By selectCondition = By.Id("condition");
        public By txtModelYear = By.Name("year");
        public By btnFilter = By.XPath("//*[@id=\"search-filter\"]//button[contains(text(),'Filter')]");
        public By lnkResult = By.XPath("//*[@id=\"result\"]//div[1]/div[1]/div[2]//div[1]/a");
        public By lnkResultToClick = By.XPath("//*[@id=\"result\"]/div/div[2]/div[1]/div[2]/div/div[1]/a");
        public By preloader = By.XPath("/html/body/footer/div[6]");

        public Vehicles(IWebDriver driver) : base(driver)
        {
        }

        public void clickOnCar() {
            waitTillElementDisplayed(webDriver.FindElement(lnkCar));
            webDriver.FindElement(lnkCar).Click();
            waitTillURLIsChanged("https://www.patpat.lk/vehicle/filter/car");
        }

        public void clickOnManufacturer(string manufacturer) {
            IWebElement manufacturerEle = webDriver.FindElement(selectManufacture);
            scrollIntoView(manufacturerEle);
            SelectElement manufacturerSelect = new SelectElement(manufacturerEle);
            manufacturerSelect.SelectByText(manufacturer);
            waitTillElementIsNotDisplayed(webDriver.FindElement(preloader));
        }

        public void clickOnModel(string model)
        {
            IWebElement modelEle = webDriver.FindElement(selectModel);
            waitTillElementDisplayed(modelEle);
            SelectElement modalSelect = new SelectElement(modelEle);
            modalSelect.SelectByValue(model);
            
        }

        public void clickOnTransmission(string transmission)
        {
            IWebElement transmissionEle = webDriver.FindElement(selectTransmission);
            scrollIntoView(transmissionEle);
            SelectElement manufacturerSelect = new SelectElement(transmissionEle);
            manufacturerSelect.SelectByText(transmission);
        }


        public void clickOnCondition(string condition)
        {
            IWebElement conditionEle = webDriver.FindElement(selectCondition);
            scrollIntoView(conditionEle);
            SelectElement manufacturerSelect = new SelectElement(conditionEle);
            manufacturerSelect.SelectByText(condition);
        }

        public void enterYearOfManufacturer(string year)
        {
            webDriver.FindElement(txtModelYear).SendKeys(year);
        }

        public void clickOnFilter()
        {
            IWebElement filterEle = webDriver.FindElement(btnFilter);
            filterEle.Click();
        }

        public ResultPage clickOnResultLink()
        {
            waitTillElementDisplayed(webDriver.FindElement(lnkCar));
            IWebElement resultEle = webDriver.FindElement(lnkResult);
            scrollIntoView(resultEle);
            webDriver.FindElement(lnkResultToClick).Click();
            return new ResultPage(webDriver);
        }


    }
}
