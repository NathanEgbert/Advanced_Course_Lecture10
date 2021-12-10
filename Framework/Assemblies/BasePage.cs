using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Assemblies
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void EnterText(By locator, string text)
        {
            GetElement(locator).SendKeys(text);
        }

        public void Click(By locator)
        {
            GetElement(locator).Click();
        }

        public IWebElement GetElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        public IReadOnlyCollection<IWebElement> GetElements(By locator)
        {
            return Driver.FindElements(locator);
        }

        public string GetTitle()
        {
            return Driver.Title;
        }

        protected IWebDriver Driver { get; set; }
    }
}
