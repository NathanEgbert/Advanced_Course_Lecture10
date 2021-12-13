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

        public static IWebElement WaitForElementPresent(IWebDriver driver, By locator, TimeSpan timeout)
        {
            IWebElement element = null;

            try
            {
                wait = new WebDriverWait(driver, timeout);
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                if(IsElementPresent(driver, locator, timeout) == true)
                {
                    element = driver.FindElement(locator);
                }

            }
            catch(WebDriverTimeoutException)
            {
                throw new Exception(String.Format("Unable to find elements using locator {0} within the duration {1}", locator, timeout));
            }

            return element;
        }

        public static IReadOnlyCollection<IWebElement> WaitForElementsPresent(IWebDriver driver, By locator, TimeSpan timeout)
        {
           IReadOnlyCollection<IWebElement> elements = null;

            try
            {
                wait = new WebDriverWait(driver, timeout);
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                if (IsElementPresent(driver, locator, timeout) == true)
                {
                    elements = driver.FindElements(locator);
                }

            }
            catch (WebDriverTimeoutException)
            {
                throw new Exception(String.Format("Unable to find elements using locator {0} within the duration {1}", locator, timeout));
            }

            return elements;
        }
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

        public static IReadOnlyCollection<IWebElement> WaitForElementsVisible(IWebDriver driver, By locator, TimeSpan timeout)
        {
            IReadOnlyCollection<IWebElement> elements = null;

            try
            {
                wait = new WebDriverWait(driver, timeout);
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                if(IsElementVisible(driver, locator, timeout) == true)
                {
                    elements = driver.FindElements(locator);
                }
            }
            catch (WebDriverTimeoutException)
            {
                throw new Exception(String.Format("Unable to find elements using locator {0}, within the duration {1}", locator, timeout));
            }

            return elements;
        }

        public static IWebElement WaitForElementVisible(IWebDriver driver, By locator, TimeSpan timeout)
        {
            IWebElement element = null;

            try
            {
                wait = new WebDriverWait(driver, timeout);
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                if (IsElementVisible(driver, locator, timeout) == true)
                {
                    element = driver.FindElement(locator);
                }
            }
            catch (WebDriverTimeoutException)
            {
                throw new Exception(String.Format("Unable to find the element using locator {0}, within the duration {1}", locator, timeout));
            }

            return element;
        }
    }
}
