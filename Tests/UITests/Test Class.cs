using FluentAssertions;
using NUnit.Framework;

namespace Tests.UITests
{
    public class Tests : UIBaseTest
    {
        
        [Test]
        public void ChromeBrowser_Launch_Successful()
        {

           
            PageContext.GoogleHome.IsDisplayed().Should().BeTrue();
        }

        [Test]
        public void ChromeBrowser_Search_Successful()
        {
            PageContext.GoogleHome.SearchText("Stats Royale").GetResults().Should().HaveCountGreaterThan(1);
       }  
    }
}