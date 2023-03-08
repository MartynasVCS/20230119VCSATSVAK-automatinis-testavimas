using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class FramesTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://demoqa.com/frames");
        }

        [Test]
        public void SwitchToFrameAndBackToMainPage()
        {
            string expectedMainPageHeadingText = "Frames";
            string expectedFrameHeadingText = "This is a sample page";
            
            string actualFrameHeadingText = Frames.GetFrameHeadingText();
            string actualMainPageHeadingText = Frames.GetMainPageHeadingText();

            Assert.AreEqual(expectedFrameHeadingText, actualFrameHeadingText);
            Assert.AreEqual(expectedMainPageHeadingText, actualMainPageHeadingText);
        }
    }
}
