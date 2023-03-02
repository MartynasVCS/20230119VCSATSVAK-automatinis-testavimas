using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class JavascriptAlertsDemoTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/javascript-alert-box-demo.html");
        }

        [Test]
        public void SimpleAlert()
        {
            string expectedText = "I am an alert box!";

            JavascriptAlertsDemo.ClickSimpleAlertButton();
            string actualText = JavascriptAlertsDemo.GetAlertText();
            JavascriptAlertsDemo.AcceptAlert();
            
            Assert.AreEqual(expectedText, actualText);
            Assert.IsFalse(JavascriptAlertsDemo.CheckIfAlertIsActive());
        }

        [Test]
        public void ConfirmAlert()
        {
            string expectedAcceptMessage = "You pressed OK!";
            string expectedDismissMessage = "You pressed Cancel!";

            JavascriptAlertsDemo.ClickConfirmAlertButton();
            JavascriptAlertsDemo.AcceptAlert();
            string actualAcceptMessage = JavascriptAlertsDemo.GetConfirmAlertMessage();

            JavascriptAlertsDemo.ClickConfirmAlertButton();
            JavascriptAlertsDemo.DismissAlert();
            string actualDismissMessage = JavascriptAlertsDemo.GetConfirmAlertMessage();

            Assert.AreEqual(expectedAcceptMessage, actualAcceptMessage);
            Assert.AreEqual(expectedDismissMessage, actualDismissMessage);
            Assert.IsFalse(JavascriptAlertsDemo.CheckIfAlertIsActive());
        }

        [Test]
        public void PromptAlert()
        {
            string expectedMessage = "Hello World!";

            JavascriptAlertsDemo.ClickPromptAlertButton();
            JavascriptAlertsDemo.EnterMessageToPromptAlert(expectedMessage);
            JavascriptAlertsDemo.AcceptAlert();
            string actualMessage = JavascriptAlertsDemo.GetPromptAlertMessage();

            StringAssert.Contains(expectedMessage, actualMessage);
            Assert.IsFalse(JavascriptAlertsDemo.CheckIfAlertIsActive());
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
