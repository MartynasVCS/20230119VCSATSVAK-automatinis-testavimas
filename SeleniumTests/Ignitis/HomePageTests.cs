using NUnit.Framework;
using SeleniumFramework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Ignitis
{
    internal class HomePageTests : BaseTestUsingChromeProfile
    {
        [Test]
        public void OpenHomePage()
        {
            Driver.OpenUrl("https://ignitis.lt/lt");
        }
    }
}
