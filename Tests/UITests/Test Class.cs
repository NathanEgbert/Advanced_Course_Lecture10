using FluentAssertions;
using Framework.Helpers;
using NUnit.Framework;
using System.Collections.Generic;

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

        public static IEnumerable<object> SearchData()
        {
            return ExcelDataHelper.ReadExcel(@"C:\Users\nathan.egbert\source\repos\Advanced_Course_Lecture10\Tests\TestData\data.xlsx", "Sheet1");

        }

        [TestCaseSource("SearchData")]
        public void ChromeBrowser_MultipleSearch_Successful(string searchText)
        {
            PageContext.GoogleHome.SearchText(searchText).GetResults().Should().HaveCountGreaterThan(1);
        }
    }
}