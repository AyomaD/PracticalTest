using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Reflection;
using OpenQA.Selenium.Firefox;


namespace PracticalTest.Base
{
    public class TestBase
    {
        public String Browser = "Chrome";
        public IWebDriver GetDriver { get; set; }

        [SetUp]
        public void startUp()
        {
            if (Browser.Equals("Chrome")) {
                GetDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }
            if (Browser.Equals("FireFox")) {
                GetDriver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }

            GetDriver.Manage().Window.Maximize();
            GetDriver.Url = "https://www.patpat.lk/";
        }

        [TearDown]
        public void quitWebdriver()
        {
            if (GetDriver != null)
            {
                GetDriver.Quit();
            }
        }
    }
}
