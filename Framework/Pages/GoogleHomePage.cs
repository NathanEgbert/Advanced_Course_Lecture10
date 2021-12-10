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

        public GoogleHomePage(IWebDriver driver) : base(driver){}

        //returning the GoogleResultsPage to use for fluent approach in the test
       public GoogleResultsPage SearchText(string textToSearch)
        {
            EnterText(By.XPath("//input[@title='Search']"), textToSearch);
            Thread.Sleep(3000);
            Click(By.XPath("//input[@value='Google Search']"));

            //returning to use GetResultsMethod in test class
            return new GoogleResultsPage(Driver);
        }

        public bool IsDisplayed() => GetTitle().Equals("Google");

    }
}
