using Framework.Assemblies;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Pages
{
   public  class GoogleResultsPage : BasePage
    {
        public GoogleResultsPage(IWebDriver driver) : base(driver) { }

        public IReadOnlyCollection<IWebElement> GetResults()
        {
            return GetElements(By.XPath("//h3[contains(text(),'Stats Royale')]"));
        }
    }
}
