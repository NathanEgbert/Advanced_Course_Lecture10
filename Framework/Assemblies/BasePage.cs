using Framework.Helpers;
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

        public void EnterText(By locator, string text, TimeSpan timeToWait)
        {
            GetElement(locator, timeToWait).SendKeys(text);
        }

        public void Click(By locator, TimeSpan timeToWait)
        {
            WaitHelper.WaitForElementVisible(Driver, locator, TimeSpan.FromSeconds(3));
            GetElement(locator, timeToWait).Click();
        }

        public IWebElement GetElement(By locator, TimeSpan timeToWait)
        {
            return WaitHelper.WaitForElementPresent(Driver, locator, timeToWait);
        }

        public IReadOnlyCollection<IWebElement> GetElements(By locator, TimeSpan timeToWait)
        {
           return  WaitHelper.WaitForElementsPresent(Driver, locator, timeToWait);
        }

        public string GetTitle()
        {
            return Driver.Title;
        }

        protected IWebDriver Driver { get; set; }
    }
}
