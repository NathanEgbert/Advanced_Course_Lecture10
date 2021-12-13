using Framework.Assemblies;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Framework.Pages
{
    public class GoogleHomePage : BasePage
    {


        By searchInput = By.XPath("//input[@title='Search']");
        By btnSearchButton = By.XPath("//input[@value='Google Search']");

        public GoogleHomePage(IWebDriver driver) : base(driver){}

        //returning the GoogleResultsPage to use for fluent approach in the test
       public GoogleResultsPage SearchText(string textToSearch)
        {
            EnterText(searchInput, textToSearch, TimeSpan.FromSeconds(5));
            Click(btnSearchButton, TimeSpan.FromSeconds(5));

            //returning to use GetResultsMethod in test class
            return new GoogleResultsPage(Driver);
        }

        public bool IsDisplayed() => GetTitle().Equals("Google");

    }
}
