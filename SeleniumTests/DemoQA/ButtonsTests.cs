using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class ButtonsTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demoqa.com/buttons");
        }

        [Test]
        public void Demo()
        {
            string expectedText = "You have done a double click";

            Buttons.DoubleClickButton();

            Assert.AreEqual(expectedText, Buttons.GetDoubleClickActionOutput());
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
