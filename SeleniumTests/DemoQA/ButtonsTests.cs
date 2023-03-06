using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class ButtonsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://demoqa.com/buttons");
        }

        [Test]
        public void DoubleClick()
        {
            string expectedText = "You have done a double click";

            Buttons.DoubleClickButton();

            Assert.AreEqual(expectedText, Buttons.GetDoubleClickActionOutput());
        }

        [Test]
        public void RightClick()
        {
            string expectedText = "You have done a right click";

            Buttons.RightClickButton();

            Assert.AreEqual(expectedText, Buttons.GetRightClickActionOutput());
        }

        [Test]
        public void LeftClickUsingActions()
        {
            string expectedText = "You have done a dynamic click";

            Buttons.LeftClickButton();

            Assert.AreEqual(expectedText, Buttons.GetLeftClickActionOutput());
        }
    }
}
