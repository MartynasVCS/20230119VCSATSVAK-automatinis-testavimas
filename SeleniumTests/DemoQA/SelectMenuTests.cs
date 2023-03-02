using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class SelectMenuTests
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://demoqa.com/select-menu");
        }

        [Test]
        public void SelectColorInOldStyleMenu()
        {
            string expectedSelectedValue = "Purple";

            SelectMenu.SelectOptionInOldStyleMenu(expectedSelectedValue);

            Assert.AreEqual(expectedSelectedValue, SelectMenu.GetSelectedValueInOldStyleMenu());
        }

        [Test]
        public void SelectTitleFromSelectOneMenu()
        {
            string expectedTitle = "Mr.";

            SelectMenu.SelectValueInSelectOneMenu(expectedTitle);

            StringAssert.Contains(expectedTitle, SelectMenu.GetSelectedValueInSelectOneMenu());
        }
    }
}
