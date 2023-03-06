using NUnit.Framework;
using SeleniumFramework;

namespace SeleniumTests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
        }

        [TearDown]
        public void Teardown()
        {
            Driver.TakeScreenshot();
            Driver.QuitDriver();
        }
    }
}
