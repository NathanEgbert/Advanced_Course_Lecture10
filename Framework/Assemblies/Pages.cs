using Framework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Assemblies
{
    public class Pages
    {
        readonly IWebDriver _driver;

        public Pages(IWebDriver driver)
        {
            _driver = driver;
        }

        public void PageRegistration()
        {
            GoogleHome = new GoogleHomePage(_driver);
            GoogleResults = new GoogleResultsPage(_driver);
        }

        public GoogleHomePage GoogleHome { get; private set; }

        public GoogleResultsPage GoogleResults { get; private set; }

    }
}
