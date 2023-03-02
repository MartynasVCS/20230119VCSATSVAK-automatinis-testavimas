using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class SelectMenuTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demoqa.com/select-menu");
        }

        [Test]
        public void SelectColorInOldStyleMenu()
        {
            string expectedSelectedValue = "Purple";

            SelectMenu.SelectOptionInOldStyleMenu(expectedSelectedValue);

            Assert.AreEqual(expectedSelectedValue, SelectMenu.GetSelectedValueInOldStyleMenu());
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
