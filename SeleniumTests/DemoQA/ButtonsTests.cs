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
        public void Demo()
        {
            string expectedText = "You have done a double click";

            Buttons.DoubleClickButton();

            Assert.AreEqual(expectedText, Buttons.GetDoubleClickActionOutput());
        }
    }
}
