using Framework.Assemblies;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Pages
{
   public  class GoogleResultsPage : BasePage
    {
        By resultLinks = By.XPath("//h3[contains(text(),'Stats Royale')]");

        public GoogleResultsPage(IWebDriver driver) : base(driver) { }

        public IReadOnlyCollection<IWebElement> GetResults()
        {
            return GetElements(resultLinks, TimeSpan.FromSeconds(5));
        }
    }
}
