using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumFramework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class BrowserWindowsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://demoqa.com/browser-windows");
        }

        [Test]
        public void SwitchToNewTabAndBackToMainPage()
        {
            string expectedMainPageHeadingText = "Browser Windows";
            string expectedNewTabHeadingText = "This is a sample page";

            BrowserWindows.ClickNewTabButton();
            string actualNewTabHeadingText = BrowserWindows.GetNewTabHeadingText();
            string actualMainPageHeadingText = BrowserWindows.GetMainPageHeadingText();

            Assert.AreEqual(expectedNewTabHeadingText, actualNewTabHeadingText);
            Assert.AreEqual(expectedMainPageHeadingText, actualMainPageHeadingText);
        }
    }
}
