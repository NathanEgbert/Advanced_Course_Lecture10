using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Framework.Helpers
{
    public static class WaitHelper
    {
        private static WebDriverWait wait;

        public static bool IsElementPresent(IWebDriver driver, By locator, TimeSpan timeout)
        {
            bool isPresent = false;

            try
            {
                wait = new WebDriverWait(driver, timeout);
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                isPresent = wait.Until(drv => drv.FindElements(locator).Any());
            }
            catch(WebDriverTimeoutException e)
            {
                return false;
            }
            return isPresent;
        }

        public static bool IsElementVisible(IWebDriver driver, By locator, TimeSpan timeout)
        {
            bool isVisible = false;

            try
            {
                wait = new WebDriverWait(driver, timeout);
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                isVisible = wait.Until(drv => drv.FindElement(locator).Displayed);
            }
            catch (WebDriverTimeoutException e)
            {
                return false;
            }
            return isVisible;
        }

        public static bool IsElementNotVisible(IWebDriver driver, By locator, TimeSpan timeout)
        {
            bool isVisible = false;

            try
            {
                wait = new WebDriverWait(driver, timeout);
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                isVisible = wait.Until(drv => !drv.FindElement(locator).Displayed);
            }
            catch (WebDriverTimeoutException e)
            {
                return false;
            }
            return isVisible;
        }

        public static bool IsElementNotPresent(IWebDriver driver, By locator, TimeSpan timeout)
        {
            bool isNotPresent = false;

            try
            {
                wait = new WebDriverWait(driver, timeout);
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                isNotPresent = wait.Until(drv => !drv.FindElements(locator).Any());
            }
            catch (WebDriverTimeoutException e)
            {
                return false;
            }
            return isNotPresent;
        }
    }
}
