using NUnit.Framework;
using SeleniumAutmation.PageObjects;


namespace SeleniumAutmation.Tests
{
    public class ExampleTest : BaseTest
    {
        public ExampleTest(string browser)
            : base(browser)
        {

        }
        [Test]
        [Category("Selenium")]
        public void testSearchPage()
        {
            using (var driver = InitializeDriver()) {
                try {
                    HomePage homepage = new HomePage(driver);
                    homepage.EnterSearchText("selenium");
                   
                }
                finally {
                    commonUtils.PrintLogs("browser", driver);
                }
            }
        }
          
    }
}
