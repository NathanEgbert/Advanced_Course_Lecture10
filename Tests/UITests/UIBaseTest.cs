using Framework.Assemblies;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.UITests
{
    public class UIBaseTest
    {
        Pages _pages;

        [SetUp]
        public void Test_Setup()
        {
            WebDriverFactory driverFactory = new WebDriverFactory();
            DriverContext = driverFactory.OpenBrowser();
            DriverContext.Manage().Window.Maximize();
            DriverContext.Url = "http://www.google.com";
            _pages = new Pages(DriverContext);
            _pages.PageRegistration();
        }

        [TearDown]
        public void Test_Teardown()
        {
            DriverContext.Quit();
        }

        protected IWebDriver DriverContext { get; set; }

        protected Pages PageContext
        {
            get
            {
                return _pages;
            }
        }

    }
}
