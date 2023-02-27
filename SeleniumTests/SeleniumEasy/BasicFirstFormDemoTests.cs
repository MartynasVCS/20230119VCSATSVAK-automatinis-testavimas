using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class BasicFirstFormDemoTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-first-form-demo.html");
        }

        [Test]
        public void SimpleFormDemoSingleInputField()
        {
            string expectedResult = "Hello World";

            BasicFirstFormDemo.EnterMessage(expectedResult);
            BasicFirstFormDemo.ClickShowMessage();
            string actualResult = BasicFirstFormDemo.GetMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("5", "2", "7")]
        [TestCase("Hello", "2", "NaN")]
        public void SimpleFormDemoTwoInputFields(string valueA, string valueB, string expectedResult)
        {
            BasicFirstFormDemo.EnterValueA(valueA);
            BasicFirstFormDemo.EnterValueB(valueB);
            BasicFirstFormDemo.ClickGetTotal();
            string actualResult = BasicFirstFormDemo.GetTotal();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
