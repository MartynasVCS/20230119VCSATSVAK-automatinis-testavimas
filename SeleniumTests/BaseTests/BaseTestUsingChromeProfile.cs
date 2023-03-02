using NUnit.Framework;
using SeleniumFramework;

namespace SeleniumTests.BaseTests
{
    internal class BaseTestUsingChromeProfile
    {
        [SetUp]
        public void Setup()
        {
            string userDataDir = "C:\\Users\\Martynas\\AppData\\Local\\Google\\Chrome\\User Data";
            string profileDir = "Profile 4";
            Driver.SetupDriver(userDataDir, profileDir);
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
