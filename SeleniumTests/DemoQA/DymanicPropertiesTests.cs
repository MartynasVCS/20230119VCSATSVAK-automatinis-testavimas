using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

[assembly: LevelOfParallelism(2)]
namespace SeleniumTests.DemoQA
{
    [Parallelizable(scope: ParallelScope.Children)]
    internal class DymanicPropertiesTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://demoqa.com/dynamic-properties");
        }

        [Test]
        public void WaitForButtonToBecomeEnabled()
        {
            DynamicProperties.WaitForFirstButtonToBeEnabled();
            
            Assert.IsTrue(DynamicProperties.CheckIfFirstButtonIsEnabled());
        }

        [Test]
        public void WaitForButtonColorToBeAsExpected()
        {
            string expectedButtonTextColor = "rgba(220, 53, 69, 1)";

            DynamicProperties.WaitForSecondButtonTextToBeOfProvidedColor(expectedButtonTextColor);

            Assert.AreEqual(expectedButtonTextColor, DynamicProperties.GetButtonTextColor());
        }

        [Test]
        public void WaitForButtonColorToChange()
        {
            string defaultButtonTextColor = DynamicProperties.GetButtonTextColor();

            DynamicProperties.WaitForSecondButtonTextColorToChangeFromDefault(defaultButtonTextColor);

            Assert.AreNotEqual(defaultButtonTextColor, DynamicProperties.GetButtonTextColor());
        }

        [Test]
        public void WaitForButtonClassToContainValue()
        {
            string expectedValue = "text-danger";

            DynamicProperties.WaitForSecondButtonClassAttributeToContainExpectedValue(expectedValue);

            StringAssert.Contains(expectedValue, DynamicProperties.GetSecondButtonClassAttributeValue());
        }

        [Test]
        public void WaitForButtonToBecomeVisible()
        {
            DynamicProperties.WaitForThirdButtonToBeVisible();

            Assert.IsTrue(DynamicProperties.CheckIfThirdButtonIsVisible());
        }
    }
}
