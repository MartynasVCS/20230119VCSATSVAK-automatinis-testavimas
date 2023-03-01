using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class DymanicPropertiesTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demoqa.com/dynamic-properties");
        }

        [Test]
        public void WaitForButtonToBecomeEnabled()
        {
            DynamicProperties.WaitForFirstButtonToBeEnabled();
            
            Assert.IsTrue(DynamicProperties.CheckIfFirstButtonIsEnabled());
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
