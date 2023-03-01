using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class BasicCheckboxDemoTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        [Test]
        public void ClickMultipleCheckboxes()
        {
            string expectedResult = "Uncheck All";

            BasicCheckboxDemo.ClickMultipleCheckboxes();
            string actualResult = BasicCheckboxDemo.GetButtonText();
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
