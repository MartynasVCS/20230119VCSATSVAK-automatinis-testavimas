using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot();
            }

            Driver.QuitDriver();
        }
    }
}
