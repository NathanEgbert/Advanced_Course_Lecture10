using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Assemblies
{
    public class WebDriverFactory
    {
        private IWebDriver driver;

        public WebDriverFactory() { }

        public IWebDriver OpenBrowser()
        {
            driver = new ChromeDriver();
            return driver;
        }

    }
}
