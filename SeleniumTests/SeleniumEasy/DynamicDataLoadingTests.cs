using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class DynamicDataLoadingTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }

        [Test]
        public void Demo()
        {
            DynamicDataLoading.ClickGetNewUserButton();
            string userInformation = DynamicDataLoading.GetUserInformation();

            StringAssert.Contains("First Name :", userInformation);
            StringAssert.Contains("Last Name :", userInformation);
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
