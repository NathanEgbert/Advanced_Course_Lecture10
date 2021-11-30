using Framework.Assemblies;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Tests.UITests
{
    public class Tests
    {
        IWebDriver driver;

        [Test, Category("tests")]
        public void ChromeBrowser_Launch_Successful()
        {
            WebDriverFactory driverFactory = new WebDriverFactory();
            driver = driverFactory.OpenBrowser();
            driver.Url = "http://www.google.com";
            driver.Close();
        }
    }
}